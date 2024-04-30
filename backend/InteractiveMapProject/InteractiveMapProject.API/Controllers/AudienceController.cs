using InteractiveMapProject.API.Utilities;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/field-of-intervention/audience")]
public class AudienceController : ControllerBase
{
    private readonly IAudienceService _audienceService;

    public AudienceController(IAudienceService audienceService)
    {
        _audienceService = audienceService;
    }

    [AllowAnonymous]
    [HttpGet("all", Name = "GetAllAudiences")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _audienceService.GetAllAsync());
    }

    [AllowAnonymous]
    [HttpGet("{id}", Name = "GetAudience")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        return Ok(await _audienceService.GetAsync(id));
    }


    [Authorize(Roles = UserRoles.SuperAdmin)]
    [HttpPost(Name = "CreateAudience")]
    public async Task<IActionResult> Create([FromBody] FieldOfInterventionCreateRequestDto request)
    {
        return Ok(await _audienceService.CreateAsync(request));
    }

    [Authorize(Roles = UserRoles.SuperAdmin)]
    [HttpPut("{id}", Name = "UpdateAudience")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] FieldOfInterventionCreateRequestDto request)
    {
        return Ok(await _audienceService.UpdateAsync(id, request));
    }

    [Authorize(Roles = UserRoles.SuperAdmin)]
    [HttpDelete("{id}", Name = "DeleteAudience")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _audienceService.DeleteAsync(id);
        return Ok();
    }
}
