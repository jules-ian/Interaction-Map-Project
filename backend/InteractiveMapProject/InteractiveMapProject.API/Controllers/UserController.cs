using InteractiveMapProject.API.Utilities;
using InteractiveMapProject.API.Validators;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/account")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly CreateUserRequestValidator _createUserRequestValidator;

    public UserController(IUserService userService, CreateUserRequestValidator createUserRequestValidator)
    {
        _userService = userService;
        _createUserRequestValidator = createUserRequestValidator;

    }

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

    [HttpPost(Name = "CheckUserCredentials")]
    public async Task<IActionResult> CheckUserCredentials([FromBody] UserCredentialsDto credentials)
    {
        if (!_createUserRequestValidator.Validate(credentials).IsValid)
        {
            return BadRequest(ModelState);
        }
        var user = await _userService.GetAsync(credentials.Email);
        if (user == null)
        {
            return NotFound();
        }
        var result = await _userService.CheckPasswordAsync(credentials.Email, credentials.Password);
        return Ok(result);
    }

    [HttpDelete("{email}", Name = "DeleteUser")]
    public async Task<IActionResult> DeleteUser([FromRoute] string email)
    {
        await _userService.DeleteAsync(email);
        return Ok();
    }

}
