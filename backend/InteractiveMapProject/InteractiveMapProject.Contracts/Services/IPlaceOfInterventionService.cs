using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace DefaultNamespace;

public interface IPlaceOfInterventionService
{
    Task<List<PlaceOfInterventionResponseDto>> GetAllAsync();
    Task<PlaceOfInterventionResponseDto> GetAsync(Guid id);
    Task<PlaceOfInterventionResponseDto> CreateAsync(PlaceOfInterventionRequestDto request);
    Task<PlaceOfInterventionResponseDto> UpdateAsync(Guid id, PlaceOfInterventionRequestDto request);
    Task DeleteAsync(Guid id);
}
