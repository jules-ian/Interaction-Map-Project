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
    private readonly IUserService _userService;
    private readonly IEmailService _emailService;
    private readonly ITokenGeneratorService _tokenGeneratorService;
    private readonly IProfessionalService _professionalService;
    private readonly CreateUserRequestValidator _createUserRequestValidator;

    public UserController(IUserService userService, IProfessionalService professionalService, ITokenGeneratorService tokenGeneratorService, CreateUserRequestValidator createUserRequestValidator,IEmailService emailService)
    {
        _userService = userService;
        _tokenGeneratorService = tokenGeneratorService;
        _createUserRequestValidator = createUserRequestValidator;
        _emailService = emailService;
        _professionalService = professionalService;
    }

#if !TESTING
    [Authorize(Roles = UserRoles.SuperAdmin)]
#endif
    [HttpGet("{email}", Name = "GetUser")]
    public async Task<IActionResult> GetUser([FromRoute] string email)
    {
        var user = await _userService.GetByEmailAsync(email);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

#if !TESTING
    [Authorize(Policy = "ProfessionalOrAdminOrSuperAdmin")]
#endif
    [HttpGet("professional/info", Name = "GetUserInformation")]
    public async Task<IActionResult> GetUserInformation()
    {
        if (User == null)
        {
            return Unauthorized();
        }
        var userEmail = User.FindFirst(ClaimTypes.Name)?.Value;
        if (userEmail == null)
        {
            return NotFound("Account not found");
        }

        var user = await _userService.GetByEmailAsync(userEmail);
        var userRoles = await _userService.GetRolesAsync(user.Email);
        if (userRoles == null || !userRoles.Contains(UserRoles.Professional) || user.ProfessionalId == null)
        {
            return NotFound("User is not a Professional");
        }
        var professionalId = (Guid)user.ProfessionalId;
        ProfessionalResponseDto response = await _professionalService.GetAsync(professionalId);

        return Ok(response);
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
        // add token to verify mail
        var token = await _userService.GenerateEmailConfirmationTokenAsync(credentials.Email);
        var confirmationLink = Url.Action(nameof(ConfirmEmail), "User", new { token, email = credentials.Email }, Request.Scheme);
        var message = new Message(new string[] { credentials.Email! }, "Confirmation email link", confirmationLink!);
        _emailService.SendEmail(message);
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
        await _userService.CreateAsync(credentials.Email, credentials.Password);
        await _userService.AddToRoleAsync(credentials.Email, UserRoles.Admin);
        var token = await _userService.GenerateEmailConfirmationTokenAsync(credentials.Email);
        var confirmationLink = Url.Action(nameof(ConfirmEmail), "User", new { token, email = credentials.Email }, Request.Scheme);
        var message = new Message(new string[] { credentials.Email! }, "Confirmation email link", confirmationLink!);
        _emailService.SendEmail(message);
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
        var user = await _userService.GetByEmailAsync(credentials.Email);
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

    /*

    [HttpGet]
    public async Task<IActionResult> TestEmail()
    {
        // TODO: change client's adresse email
        var message = new Message(new string[] { "zhuxuxinapp@gmail.com" }, "<h1>TEST PIR</h1>", "Test message content");
        _emailService.SendEmail(message);
        return Ok();
    }
    */
    [HttpGet("ConfirmEmail")]
    public async Task<IActionResult> ConfirmEmail(string token, string email)
    {
        await _userService.ConfirmEmailAsync(email, token);
        return Ok();
    }

    [HttpPost]
    [AllowAnonymous]
    [Route("forgot-password")]
    public async Task<IActionResult> ForgotPassword([Required] string email)
    {
        var user = await _userService.GetAsync(email);
        if (user != null)
        {
            // TODO: think about parameter
            var token = await _userService.GeneratePasswordResetTokenAsync(email);
            var forgotlink = Url.Action("ResetPassword", "User", new { token, email = user.Email }, Request.Scheme);
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

    [HttpPost]
    [AllowAnonymous]
    [Route("reset-password")]
    public async Task<IActionResult> ResetPassword(ResetPassword resetPassword)
    {
        await _userService.ResetPasswordAsync(resetPassword);
        return Ok();
    }


}


