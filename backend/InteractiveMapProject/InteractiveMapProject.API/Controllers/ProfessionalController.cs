using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/professional")]
public class ProfessionalController : ControllerBase
{
    private readonly IProfessionalService _professionalService;

    public ProfessionalController(IProfessionalService professionalService)
    {
        _professionalService = professionalService;
    }

    [HttpGet("all", Name = "GetAllProfessionals")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _professionalService.GetAllAsync());
    }

    [HttpGet("{id}", Name = "GetProfessional")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        ProfessionalResponseDto response = await _professionalService.GetAsync(id);
        return Ok(response);
    }

    [HttpPost(Name = "CreateProfessional")]
    public async Task<IActionResult> Create([FromBody] ProfessionalRequestDto request)
    {
        return Ok(await _professionalService.CreateAsync(request));
    }

    [HttpPut("{id}", Name = "UpdateProfessional")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] ProfessionalRequestDto request)
    {
        return Ok(await _professionalService.UpdateAsync(id, request));
    }

    [HttpDelete(Name = "DeleteProfessional")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _professionalService.DeleteAsync(id);
        return Ok();
    }
}
