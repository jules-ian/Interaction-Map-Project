using DefaultNamespace;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
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

    [HttpGet("all", Name = "GetAllMissions")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _missionService.GetAllAsync());
    }

    [HttpGet("{id}", Name = "GetMission")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        return Ok(await _missionService.GetAsync(id));
    }

    [HttpPost(Name = "CreateMission")]
    public async Task<IActionResult> Create([FromBody] MissionRequestDto request)
    {
        return Ok(await _missionService.CreateAsync(request));
    }

    [HttpPut("{id}", Name = "UpdateMission")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] MissionRequestDto request)
    {
        return Ok(await _missionService.UpdateAsync(id, request));
    }

    [HttpDelete("{id}", Name = "DeleteMission")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _missionService.DeleteAsync(id);
        return Ok();
    }
}
