using DefaultNamespace;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
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

    [HttpGet("all", Name = "GetAllPlacesOfIntervention")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _placeOfInterventionService.GetAllAsync());
    }

    [HttpGet("{id}", Name = "GetPlaceOfIntervention")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        return Ok(await _placeOfInterventionService.GetAsync(id));
    }

    [HttpPost(Name = "CreatePlaceOfIntervention")]
    public async Task<IActionResult> Create([FromBody] PlaceOfInterventionRequestDto request)
    {
        return Ok(await _placeOfInterventionService.CreateAsync(request));
    }

    [HttpPut("{id}", Name = "UpdatePlaceOfIntervention")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] PlaceOfInterventionRequestDto request)
    {
        return Ok(await _placeOfInterventionService.UpdateAsync(id, request));
    }

    [HttpDelete("{id}", Name = "DeletePlaceOfIntervention")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _placeOfInterventionService.DeleteAsync(id);
        return Ok();
    }
}
