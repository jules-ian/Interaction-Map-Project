using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.Contracts.Services;

public interface IMissionService
{
    Task<List<FieldOfInterventionResponseDto>> GetAllAsync();
    Task<FieldOfInterventionResponseDto> GetAsync(Guid id);
    Task<FieldOfInterventionResponseDto> CreateAsync(FieldOfInterventionCreateRequestDto request);
    Task<FieldOfInterventionResponseDto> UpdateAsync(Guid id, FieldOfInterventionCreateRequestDto request);
    Task DeleteAsync(Guid id);
}
