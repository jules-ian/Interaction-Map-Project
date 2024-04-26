using InteractiveMapProject.API.Utilities;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[Authorize(Roles = UserRoles.Admin)]
[ApiController]
[Route("api/validation-status")]
public class ValidationStatusController : ControllerBase
{
    private readonly IValidationStatusService _validationStatusService;

    public ValidationStatusController(IValidationStatusService validationStatusService)
    {
        _validationStatusService = validationStatusService;
    }

    [HttpGet("all", Name = "GetAllValidationStatuses")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _validationStatusService.GetAllAsync());
    }
}
