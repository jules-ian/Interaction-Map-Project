using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.Contracts.Services;

public interface IAudienceService
{
    Task<List<IdNameDto>> GetAllAsync();
    Task<IdNameDto> GetAsync(Guid id);
    Task<IdNameDto> CreateAsync(FieldOfInterventionCreateRequestDto request);
    Task<IdNameDto> UpdateAsync(Guid id, FieldOfInterventionCreateRequestDto request);
    Task DeleteAsync(Guid id);
}
