using AutoMapper;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Exceptions;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.UoW;

namespace InteractiveMapProject.Services;

public class ProfessionalService : IProfessionalService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;
    private readonly IGeocodingService _geocodingService;

    public ProfessionalService(IUnitOfWork uow, IMapper mapper, IGeocodingService geocodingService)
    {
        _uow = uow;
        _mapper = mapper;
        _geocodingService = geocodingService;
    }

    public async Task<List<ProfessionalResponseDto>> GetAllAsync()
    {
        List<Professional> professionals = await _uow.Professionals.GetAllAsync();
        return professionals.Select(p => _mapper.Map<ProfessionalResponseDto>(p)).ToList();
        // TODO: map fields of intervention
    }

    public async Task<List<ProfessionalResponseDto>> GetAllFilteredAsync(ProfessionalFilterRequest filterRequest)
    {
        List<Professional> professionals = await _uow.Professionals.GetAllAsync(filterRequest);
        return professionals.Select(p => _mapper.Map<ProfessionalResponseDto>(p)).ToList();
        // TODO: map fields of intervention
    }

    public async Task<ProfessionalResponseDto> GetAsync(Guid id)
    {
        Professional professional = await _uow.Professionals.GetAsync(id) ?? throw new EntityNotFoundException("There is no professional with that id.");
        return _mapper.Map<ProfessionalResponseDto>(professional);
        // TODO: map fields of intervention
    }

    public async Task<ProfessionalResponseDto> CreateAsync(ProfessionalRequestDto request)
    {
        Professional professional = _mapper.Map<Professional>(request);
        Geolocation geolocation = await _geocodingService.GetGeolocationFromAddressAsync(request.Address) ?? throw new InvalidAddressException("Address is invalid.");
        professional.Geolocation = geolocation;
        // TODO: map fields of intervention
        _uow.Professionals.Add(professional);
        await _uow.SaveChangesAsync();
        return _mapper.Map<ProfessionalResponseDto>(professional);
    }

    public async Task<ProfessionalResponseDto> UpdateAsync(Guid id, ProfessionalRequestDto request)
    {
        Professional professional = await _uow.Professionals.GetAsync(id) ?? throw new EntityNotFoundException("There is no professional with that id.");
        professional = _mapper.Map(request, professional);
        // TODO: map fields of intervention
        _uow.Professionals.Update(professional);
        await _uow.SaveChangesAsync();
        return _mapper.Map<ProfessionalResponseDto>(professional);
    }

    public async Task DeleteAsync(Guid id)
    {
        Professional professional = await _uow.Professionals.GetAsync(id) ?? throw new EntityNotFoundException("There is no professional with that id.");
        _uow.Professionals.Remove(professional);
        await _uow.SaveChangesAsync();
    }
}
