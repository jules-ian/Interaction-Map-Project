using System.ComponentModel.DataAnnotations;
using InteractiveMapProject.API.Email;
using InteractiveMapProject.API.Email_Services;
using InteractiveMapProject.Contracts.Entities;
using Microsoft.AspNetCore.Identity.UI.V5.Pages.Account.Internal;
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
public class UserController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IUserService _userService;
    private readonly IEmailService _emailService;

    public UserController(IUserService userService, ITokenGeneratorService tokenGeneratorService, CreateUserRequestValidator createUserRequestValidator,IEmailService emailService)
    {
        _userService = userService;
        _tokenGeneratorService = tokenGeneratorService;
        _createUserRequestValidator = createUserRequestValidator;
        _emailService = emailService;

    }

    [Authorize(Roles = UserRoles.SuperAdmin)]
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

    [Authorize(Policy = "AdminOrSuperAdmin")]
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

    [Authorize(Roles = UserRoles.SuperAdmin)]
    [HttpPost("admin/create", Name = "CreateAdminAccount")]
    public async Task<IActionResult> CreateAdminAccount([FromBody] UserCredentialsDto credentials)
    {
        if (!_createUserRequestValidator.Validate(credentials).IsValid)
        {
            return BadRequest(ModelState);
        }
        await _userService.CreateAsync(credentials.Email, credentials.Password);
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


    [AllowAnonymous]
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

    [Authorize(Roles = UserRoles.SuperAdmin)]
    [HttpDelete("{email}", Name = "DeleteUser")]
    public async Task<IActionResult> DeleteUser([FromRoute] string email)
    {
        await _userService.DeleteAsync(email);
        return Ok();
    }
        

    [HttpGet]
    public async Task<IActionResult> TestEmail()
    {
        // TODO: change client's adresse email
        var message = new Message(new string[] { "xxx@gmail.com" }, "TEST PIR", "Test message content");
        _emailService.SendEmail(message);
        return Ok();
    }

    [HttpGet("ConfirmEmail")]
    public async Task<IActionResult> ConfirmEmail(string token, string email)
    {

        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return Ok();
            }
        }
        return NotFound();
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> ForgotPassword([Required] string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var forgotlink = Url.Action("ResetPassword", "Authentication", new { token, email = user.Email }, Request.Scheme);
            var message = new Message(new string[] { user.Email! }, "Forget Password resend email link", forgotlink!);
            _emailService.SendEmail(message);
            return Ok();
        }
        return NotFound();
    }

    [HttpGet("reset-password")]
    public async Task<IActionResult> ResetPassword(string token, string email)
    {
        var example = new ResetPassword { Token = token, Email = email };
        return Ok(new{
            example
        });
    }


}


