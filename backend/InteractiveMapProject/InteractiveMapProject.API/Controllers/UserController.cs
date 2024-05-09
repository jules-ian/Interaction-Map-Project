using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using InteractiveMapProject.API.Utilities;
using InteractiveMapProject.API.Validators;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NuGet.Common;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/account")]
public class UserController : ControllerBase // TODO : API to allow a pro to get its information / modify them / make a modif request
{
    private readonly IUserService _userService;
    private readonly ITokenGeneratorService _tokenGeneratorService;
    private readonly CreateUserRequestValidator _createUserRequestValidator;

    public UserController(IUserService userService, ITokenGeneratorService tokenGeneratorService, CreateUserRequestValidator createUserRequestValidator)
    {
        _userService = userService;
        _tokenGeneratorService = tokenGeneratorService;
        _createUserRequestValidator = createUserRequestValidator;

    }

#if !TESTING
    [Authorize(Roles = UserRoles.SuperAdmin)]
#endif
    [HttpGet("{email}", Name = "GetUser")]
    public async Task<IActionResult> GetUser([FromRoute] string email)
    {
        var user = await _userService.GetAsync(email);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

#if !TESTING
    [Authorize(Policy = "ProfessionalOrAdminOrSuperAdmin")]
#endif
    [HttpGet(Name = "GetUserInformation")]
    public async Task<IActionResult> GetUserInformation()
    {
        var email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;
        var user = await _userService.GetAsync(email);
        var userRoles = await _userService.GetRolesAsync(email);
        if (user == null || userRoles == null || !userRoles.Contains(UserRoles.Professional))
        {
            return NotFound();
        }
        return Ok(user);
    }


#if !TESTING
    [Authorize(Policy = "AdminOrSuperAdmin")]
#endif
    [HttpPost("professional/create", Name = "CreateProfessionalAccount")]
    public async Task<IActionResult> CreateProfessionalAccount([FromBody] UserCredentialsDto credentials)
    {
        if (!_createUserRequestValidator.Validate(credentials).IsValid)
        {
            return BadRequest(ModelState);
        }
        await _userService.CreateAsync(credentials.Email, credentials.Password);
        await _userService.AddToRoleAsync(credentials.Email, UserRoles.Professional);
        return Ok();
    }

#if !TESTING
    [Authorize(Roles = UserRoles.SuperAdmin)]
#endif
    [HttpPost("admin/create", Name = "CreateAdminAccount")]
    public async Task<IActionResult> CreateAdminAccount([FromBody] UserCredentialsDto credentials)
    {
        if (!_createUserRequestValidator.Validate(credentials).IsValid)
        {
            return BadRequest(ModelState);
        }
        await _userService.CreateAsync(credentials.Email, credentials.Password, null);
        await _userService.AddToRoleAsync(credentials.Email, UserRoles.Admin);
        return Ok();
    }

    /*[HttpPost("login", Name = "CheckUserCredentials")]
    public async Task<IActionResult> CheckUserCredentials([FromBody] UserCredentialsDto credentials)
    {
        if (!_createUserRequestValidator.Validate(credentials).IsValid)
        {
            return BadRequest("Email not valid or empty credentials fields");
        }
        var user = await _userService.GetAsync(credentials.Email);
        if (user == null)
        {
            return NotFound();
        }
        var result = await _userService.CheckPasswordAsync(credentials.Email, credentials.Password);
        return Ok(result);
    }*/

#if !TESTING
    [AllowAnonymous]
#endif
    [HttpPost("login", Name = "CheckUserCredentials")]
    public async Task<IActionResult> CheckUserCredentials([FromBody] UserCredentialsDto credentials)
    {
        if (!_createUserRequestValidator.Validate(credentials).IsValid)
        {
            return BadRequest("Email not valid or empty credentials fields");
        }
        var user = await _userService.GetAsync(credentials.Email);
        if (user != null && await _userService.CheckPasswordAsync(credentials.Email, credentials.Password))
        {
            var userRoles = await _userService.GetRolesAsync(credentials.Email);

            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            var token = _tokenGeneratorService.GetToken(authClaims);

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expiration = token.ValidTo
            });
        }
        return Unauthorized();
    }

#if !TESTING
    [Authorize(Roles = UserRoles.SuperAdmin)]
#endif
    [HttpDelete("{email}", Name = "DeleteUser")]
    public async Task<IActionResult> DeleteUser([FromRoute] string email)
    {
        await _userService.DeleteAsync(email);
        return Ok();
    }

}
