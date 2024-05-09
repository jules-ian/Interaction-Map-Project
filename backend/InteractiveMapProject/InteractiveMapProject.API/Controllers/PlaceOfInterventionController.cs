using InteractiveMapProject.API.Utilities;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMapProject.API.Controllers;

[ApiController]
[Route("api/field-of-intervention/place-of-intervention")]
public class PlaceOfInterventionController : ControllerBase
{
    private readonly IPlaceOfInterventionService _placeOfInterventionService;

    public PlaceOfInterventionController(IPlaceOfInterventionService placeOfInterventionService)
    {
        _placeOfInterventionService = placeOfInterventionService;
    }

    [AllowAnonymous]
    [HttpGet("all", Name = "GetAllPlacesOfIntervention")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _placeOfInterventionService.GetAllAsync());
    }

    [AllowAnonymous]
    [HttpGet("{id}", Name = "GetPlaceOfIntervention")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        return Ok(await _placeOfInterventionService.GetAsync(id));
    }

#if !TESTING
    [Authorize(Roles = UserRoles.SuperAdmin)]
#endif
    [HttpPost(Name = "CreatePlaceOfIntervention")]
    public async Task<IActionResult> Create([FromBody] FieldOfInterventionCreateRequestDto request)
    {
        return Ok(await _placeOfInterventionService.CreateAsync(request));
    }

#if !TESTING
    [Authorize(Roles = UserRoles.SuperAdmin)]
#endif
    [HttpPut("{id}", Name = "UpdatePlaceOfIntervention")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] FieldOfInterventionCreateRequestDto request)
    {
        return Ok(await _placeOfInterventionService.UpdateAsync(id, request));
    }

#if !TESTING
    [Authorize(Roles = UserRoles.SuperAdmin)]
#endif
    [HttpDelete("{id}", Name = "DeletePlaceOfIntervention")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _placeOfInterventionService.DeleteAsync(id);
        return Ok();
    }
}
