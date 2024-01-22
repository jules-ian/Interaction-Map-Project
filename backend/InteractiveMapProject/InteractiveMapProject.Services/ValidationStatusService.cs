using AutoMapper;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.UoW;

namespace InteractiveMapProject.Services;

public class ValidationStatusService : IValidationStatusService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public ValidationStatusService(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }

    public async Task<List<IdNameDto>> GetAllAsync()
    {
        List<ValidationStatus> validationStatuses = await _uow.ValidationStatuses.GetAllAsync();
        return validationStatuses.Select(a => _mapper.Map<IdNameDto>(a)).ToList();
    }
}
