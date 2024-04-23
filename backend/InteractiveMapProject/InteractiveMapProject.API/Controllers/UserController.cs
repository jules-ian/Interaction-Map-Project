using InteractiveMapProject.API.Email;
using InteractiveMapProject.API.Email_Services;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
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
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        await _userService.CreateAsync(request.Email, request.Password);
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
}
