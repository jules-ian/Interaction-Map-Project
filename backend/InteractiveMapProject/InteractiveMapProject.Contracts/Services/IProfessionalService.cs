using InteractiveMapProject.Contracts.Dtos;

namespace InteractiveMapProject.Contracts.Services;

public interface IProfessionalService
{
    Task<List<ProfessionalResponseDto>> GetAllAsync();
    Task<ProfessionalResponseDto?> GetAsync(Guid id);
    Task<ProfessionalResponseDto> CreateAsync(ProfessionalResponseDto request);
    Task DeleteAsync(Guid id);
}
