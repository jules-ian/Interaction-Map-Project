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

}
