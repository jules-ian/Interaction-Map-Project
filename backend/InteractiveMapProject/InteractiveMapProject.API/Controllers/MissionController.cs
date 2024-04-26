using InteractiveMapProject.API.Utilities;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/field-of-intervention/mission")]
public class MissionController : ControllerBase
{
    private readonly IMissionService _missionService;

    public MissionController(IMissionService missionService)
    {
        _missionService = missionService;
    }

    [AllowAnonymous]
    [HttpGet("all", Name = "GetAllMissions")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _missionService.GetAllAsync());
    }

    [AllowAnonymous]
    [HttpGet("{id}", Name = "GetMission")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        return Ok(await _missionService.GetAsync(id));
    }

    [Authorize(Roles = UserRoles.SuperAdmin)]
    [HttpPost(Name = "CreateMission")]
    public async Task<IActionResult> Create([FromBody] FieldOfInterventionCreateRequestDto request)
    {
        return Ok(await _missionService.CreateAsync(request));
    }

    [Authorize(Roles = UserRoles.SuperAdmin)]
    [HttpPut("{id}", Name = "UpdateMission")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] FieldOfInterventionCreateRequestDto request)
    {
        return Ok(await _missionService.UpdateAsync(id, request));
    }

    [Authorize(Roles = UserRoles.SuperAdmin)]
    [HttpDelete("{id}", Name = "DeleteMission")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _missionService.DeleteAsync(id);
        return Ok();
    }
}
