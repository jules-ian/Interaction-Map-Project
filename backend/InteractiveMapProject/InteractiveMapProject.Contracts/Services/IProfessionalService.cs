using InteractiveMapProject.Contracts.Dtos;

namespace InteractiveMapProject.Contracts.Services;

public interface IProfessionalService
{
    Task<List<ProfessionalResponseDto>> GetAllAsync();
    Task<ProfessionalResponseDto> GetAsync(Guid id);
    Task<ProfessionalResponseDto> CreateAsync(ProfessionalRequestDto request);
    Task<ProfessionalResponseDto> UpdateAsync(Guid id, ProfessionalRequestDto request);
    Task DeleteAsync(Guid id);
}
