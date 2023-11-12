using AutoMapper;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Exceptions;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.UoW;

namespace InteractiveMapProject.Services;

public class ProfessionalService : IProfessionalService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public ProfessionalService(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }

    public async Task<List<ProfessionalResponseDto>> GetAllAsync()
    {
        List<Professional> professionals = await _uow.Professionals.GetAllAsync();
        return professionals.Select(p => _mapper.Map<ProfessionalResponseDto>(p)).ToList();
    }

    public async Task<ProfessionalResponseDto?> GetAsync(Guid id)
    {
        Professional? professional = await _uow.Professionals.GetAsync(id) ?? throw new EntityNotFoundException("There is no professional with that id.");
        return _mapper.Map<ProfessionalResponseDto>(professional);
    }

    public async Task<ProfessionalResponseDto> CreateAsync(ProfessionalResponseDto request)
    {
        Professional professional = _mapper.Map<Professional>(request);
        _uow.Professionals.Add(professional);
        await _uow.SaveChangesAsync();
        return _mapper.Map<ProfessionalResponseDto>(professional);
    }

    public async Task DeleteAsync(Guid id)
    {
        Professional? professional = await _uow.Professionals.GetAsync(id) ?? throw new EntityNotFoundException("There is no professional with that id.");
        _uow.Professionals.Remove(professional);
        await _uow.SaveChangesAsync();
    }
}
