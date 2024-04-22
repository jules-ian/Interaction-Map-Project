using InteractiveMapProject.API.Validators;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly CreateUserRequestValidator _createUserRequestValidator;

    public UserController(IUserService userService, CreateUserRequestValidator createUserRequestValidator)
    {
        _userService = userService;
        _createUserRequestValidator = createUserRequestValidator;

    }

    [HttpGet("{email}", Name = "GetUserByEmail")]
    public async Task<IActionResult> GetUserByEmail([FromRoute] string email)
    {
        var user = await _userService.GetAsync(email);
        return Ok(user);
    }

    [HttpPost("create", Name = "CreateUser")]
    public async Task<IActionResult> CreateUser([FromBody] UserCredentials request)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        await _userService.CreateAsync(request.Email, request.Password);
        return Ok();
    }

    [HttpGet("{credentials}", Name = "CheckUserCredentials")]
    public async Task<IActionResult> CheckUserCredentials([FromRoute] UserCredentials credentials)
    {
        var user = await _userService.GetAsync(credentials.Email);
        if(user == null)
        {
            return NotFound();
        }
        var result = await _userService.CheckPasswordAsync(credentials.Email, credentials.Password);
        return Ok(result);
    }

}
