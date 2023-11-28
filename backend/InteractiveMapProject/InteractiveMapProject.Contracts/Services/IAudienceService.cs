using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace DefaultNamespace;

public interface IAudienceService
{
    Task<List<AudienceResponseDto>> GetAllAsync();
    Task<AudienceResponseDto> GetAsync(Guid id);
    Task<AudienceResponseDto> CreateAsync(AudienceRequestDto request);
    Task<AudienceResponseDto> UpdateAsync(Guid id, AudienceRequestDto request);
    Task DeleteAsync(Guid id);
}
