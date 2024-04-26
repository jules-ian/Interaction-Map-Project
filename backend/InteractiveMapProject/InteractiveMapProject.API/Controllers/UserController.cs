using System.ComponentModel.DataAnnotations;
using InteractiveMapProject.API.Email;
using InteractiveMapProject.API.Email_Services;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V5.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IUserService _userService;
    private readonly IEmailService _emailService;

    public UserController(IUserService userService,IEmailService emailService)
    {
        _userService = userService;
        _emailService = emailService;
    }

    [HttpGet("{email}", Name = "GetUserByEmail")]
    public async Task<IActionResult> GetUserByEmail([FromRoute] string email)
    {
        var user = await _userService.GetAsync(email);
        return Ok(user);
    }

    [HttpPost("create", Name = "CreateUser")]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        // TODO: Check email exists


        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        await _userService.CreateAsync(request.Email, request.Password);

        // Add role
        // Add token to verify email
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var confirmationLink = Url.Action(nameof(ConfirmEmail), "Authentication", new { token, email = user.Email }, Request.Scheme);
        var message = new Message(new string[] { user.Email! }, "Confirmation email link", confirmationLink!);
        _emailService.SendEmail(message);



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


