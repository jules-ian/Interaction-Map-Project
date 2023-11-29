using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.Contracts.Services;

public interface IMissionService
{
    Task<List<MissionResponseDto>> GetAllAsync();
    Task<MissionResponseDto> GetAsync(Guid id);
    Task<MissionResponseDto> CreateAsync(MissionRequestDto request);
    Task<MissionResponseDto> UpdateAsync(Guid id, MissionRequestDto request);
    Task DeleteAsync(Guid id);
}
