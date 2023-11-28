using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace DefaultNamespace;

public interface IMissionService
{
    Task<List<MissionResponseDto>> GetAllAsync();
    Task<MissionResponseDto> GetAsync(Guid id);
    Task<MissionResponseDto> CreateAsync(MissionRequestDto request);
    Task<MissionResponseDto> UpdateAsync(Guid id, MissionRequestDto request);
    Task DeleteAsync(Guid id);
}
