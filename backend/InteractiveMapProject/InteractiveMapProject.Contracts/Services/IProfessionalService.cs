using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;

namespace InteractiveMapProject.Contracts.Services;

public interface IProfessionalService
{
    Task<List<ProfessionalResponseDto>> GetAllAsync();
    Task<List<ProfessionalResponseDto>> GetAllFilteredAsync(ProfessionalFilterRequest filterRequest);
    Task<ProfessionalResponseDto> GetAsync(Guid id);
    Task<ProfessionalResponseDto> GetAsync(Guid statusId, Guid id);
    Task ValidateAsync(Guid pendingProfessionalId, ValidationDto validationDto);
    Task DeleteAsync(Guid id);
}
