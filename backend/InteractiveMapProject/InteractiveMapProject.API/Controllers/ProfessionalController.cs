using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/professional")]
public class ProfessionalController : ControllerBase
{
    private readonly IProfessionalService _professionalService;
    private readonly IPendingProfessionalService _pendingProfessionalService;

    public ProfessionalController(IProfessionalService professionalService,
        IPendingProfessionalService pendingProfessionalService)
    {
        _professionalService = professionalService;
        _pendingProfessionalService = pendingProfessionalService;
    }

    //TODO: change post address to "approved/all"
    [HttpGet("all", Name = "GetAllProfessionals")]
    public async Task<IActionResult> GetAllApproved()
    {
        return Ok(await _professionalService.GetAllAsync());
    }

    [HttpGet("pending/all", Name = "GetAllPendingProfessionals")]
    public async Task<IActionResult> GetAllPending()
    {
        return Ok(await _pendingProfessionalService.GetAllAsync());
    }

    //TODO: change post address to "approved/filtered"
    [HttpPost("all-filtered", Name = "GetAllProfessionalsFiltered")]
    public async Task<IActionResult> GetAllApprovedFiltered(ProfessionalFilterRequest filterRequest)
    {
        return Ok(await _professionalService.GetAllFilteredAsync(filterRequest));
    }

    //TODO: change post address to "approved/{id}"
    [HttpGet("{id}", Name = "GetApprovedProfessional")]
    public async Task<IActionResult> GetApproved([FromRoute] Guid id)
    {
        ProfessionalResponseDto response = await _professionalService.GetAsync(id);
        return Ok(response);
    }

    [HttpGet("pending/{id}", Name = "GetPendingProfessional")]
    public async Task<IActionResult> GetPending([FromRoute] Guid id)
    {
        PendingProfessionalResponseDto response = await _pendingProfessionalService.GetAsync(id);
        return Ok(response);
    }

    [HttpGet("{statusId}/{id}", Name = "GetProfessional")]
    public async Task<IActionResult> GetProfessional([FromRoute] Guid statusId, [FromRoute] Guid id)
    {
        ProfessionalResponseDto response = await _professionalService.GetAsync(statusId, id);
        return Ok(response);
    }

    [HttpPost(Name = "CreateProfessional")]
    public async Task<IActionResult> Create([FromBody] ProfessionalRequestDto request)
    {
        return Ok(await _pendingProfessionalService.CreateAsync(request));
    }

    /**
     * Update is currently written with the assumption there can only be one request to be approved per user and if
     * a new request is added it will override the previous one
     */
    //TODO: consensus on how exactly update works, is it only possible on the active user or also on pending requests
    //is expecting professionalId not pendingProfessionalId
    [HttpPut("{id}", Name = "UpdateProfessional")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] ProfessionalRequestDto request)
    {
        return Ok(await _pendingProfessionalService.UpdateAsync(id, request));
    }

    //TODO: change post address to "approved/{id}"
    [HttpDelete("{id}", Name = "DeleteProfessional")]
    public async Task<IActionResult> DeleteProfessional([FromRoute] Guid id)
    {
        await _professionalService.DeleteAsync(id);
        return Ok();
    }

    [HttpDelete("pending/{id}", Name = "DeletePendingProfessional")]
    public async Task<IActionResult> DeletePendingProfessional([FromRoute] Guid id)
    {
        await _pendingProfessionalService.DeleteAsync(id);
        return Ok();
    }

    [HttpPost("validate/{pendingProfessionalId}", Name = "ValidateProfessional")]
    public async Task<IActionResult> Validate([FromRoute] Guid pendingProfessionalId,
        [FromBody] ValidationDto validationDto)
    {
        await _professionalService.ValidateAsync(pendingProfessionalId, validationDto);
        return Ok();
    }

    //TODO: add mail sending service
}
