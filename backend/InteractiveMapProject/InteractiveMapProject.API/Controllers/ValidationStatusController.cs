using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

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
