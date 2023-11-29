using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;

namespace InteractiveMapProject.Contracts.Services;

public interface IProfessionalService
{
    Task<List<ProfessionalResponseDto>> GetAllAsync(ProfessionalFilterRequest filterRequest);
    Task<ProfessionalResponseDto> GetAsync(Guid id);
    Task<ProfessionalResponseDto> CreateAsync(ProfessionalRequestDto request);
    Task<ProfessionalResponseDto> UpdateAsync(Guid id, ProfessionalRequestDto request);
    Task DeleteAsync(Guid id);
}
