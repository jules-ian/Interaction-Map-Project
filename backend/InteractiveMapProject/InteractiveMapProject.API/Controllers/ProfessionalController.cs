using InteractiveMapProject.API.Utilities;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
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

    [Authorize(Policy = "ProfessionalOrAdminOrSuperAdmin")]
    [HttpGet("approved/all", Name = "GetAllApproved")]
    public async Task<IActionResult> GetAllApproved()
    {
        return Ok(await _professionalService.GetAllAsync());
    }

    [Authorize(Policy = "AdminOrSuperAdmin")]
    [HttpGet("pending/all", Name = "GetAllPending")]
    public async Task<IActionResult> GetAllPending()
    {
        return Ok(await _pendingProfessionalService.GetAllAsync());
    }

    [Authorize(Policy = "ProfessionalOrAdminOrSuperAdmin")]
    [HttpPost("approved/filtered", Name = "GetAllApprovedFiltered")]
    public async Task<IActionResult> GetAllApprovedFiltered(ProfessionalFilterRequest filterRequest)
    {
        return Ok(await _professionalService.GetAllFilteredAsync(filterRequest));
    }

    [Authorize(Policy = "ProfessionalOrAdminOrSuperAdmin")]
    [HttpGet("approved/{id}", Name = "GetApproved")]
    public async Task<IActionResult> GetApproved([FromRoute] Guid id)
    {
        ProfessionalResponseDto response = await _professionalService.GetAsync(id);
        return Ok(response);
    }

    [Authorize(Policy = "AdminOrSuperAdmin")]
    [HttpGet("pending/{id}", Name = "GetPending")]
    public async Task<IActionResult> GetPending([FromRoute] Guid id)
    {
        PendingProfessionalResponseDto response = await _pendingProfessionalService.GetAsync(id);
        return Ok(response);
    }
    // TODO : Set Authorizations for the following 3 methods
    [Authorize(Roles = UserRoles.Admin)]
    [HttpGet("{statusId}/{id}", Name = "GetProfessional")]
    public async Task<IActionResult> GetProfessional([FromRoute] Guid statusId, [FromRoute] Guid id)
    {
        ProfessionalResponseDto response = await _professionalService.GetAsync(statusId, id);
        return Ok(response);
    }

    [Authorize(Roles = UserRoles.Professional)]
    [HttpPost(Name = "CreateProfessional")]
    public async Task<IActionResult> CreateProfessional([FromBody] ProfessionalRequestDto request)
    {
        return Ok(await _pendingProfessionalService.CreateAsync(request));
    }

    /**
     * Update is currently written with the assumption there can only be one request to be approved per user and if
     * a new request is added it will override the previous one
     */
    [Authorize(Roles = UserRoles.Professional)]
    [HttpPut("{professionalId}", Name = "UpdateProfessional")]
    public async Task<IActionResult> UpdateProfessional([FromRoute] Guid id, [FromBody] ProfessionalRequestDto request)
    {
        return Ok(await _pendingProfessionalService.UpdateAsync(id, request));
    }

    [Authorize(Roles = UserRoles.SuperAdmin)]
    [HttpDelete("approved/{id}", Name = "DeleteApproved")]
    public async Task<IActionResult> DeleteApproved([FromRoute] Guid id)
    {
        await _professionalService.DeleteAsync(id);
        return Ok();
    }

    [Authorize(Policy = "AdminOrSuperAdmin")]
    [HttpDelete("pending/{id}", Name = "DeletePending")]
    public async Task<IActionResult> DeletePending([FromRoute] Guid id)
    {
        await _pendingProfessionalService.DeleteAsync(id);
        return Ok();
    }

    [Authorize(Policy = "AdminOrSuperAdmin")]
    [HttpPost("validate/{pendingProfessionalId}", Name = "ValidatePending")]
    public async Task<IActionResult> ValidatePending([FromRoute] Guid pendingProfessionalId,
        [FromBody] ValidationDto validationDto)
    {
        await _professionalService.ValidateAsync(pendingProfessionalId, validationDto);
        return Ok();
    }
}
