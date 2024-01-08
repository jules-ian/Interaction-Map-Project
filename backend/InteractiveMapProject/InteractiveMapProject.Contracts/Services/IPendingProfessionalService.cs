using InteractiveMapProject.Contracts.Dtos;

namespace InteractiveMapProject.Contracts.Services;

public interface IPendingProfessionalService
{
    Task<List<PendingProfessionalResponseDto>> GetAllAsync();

    Task<PendingProfessionalResponseDto> GetAsync(Guid id);

    Task<PendingProfessionalResponseDto> CreateAsync(ProfessionalRequestDto request);

    Task<PendingProfessionalResponseDto> UpdateAsync(Guid professionalId, ProfessionalRequestDto request);

    Task DeleteAsync(Guid id);
}
