using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
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
}
