using InteractiveMapProject.Contracts.Dtos;

namespace InteractiveMapProject.Contracts.Services;

public interface IValidationStatusService
{
    Task<List<IdNameDto>> GetAllAsync();
}
