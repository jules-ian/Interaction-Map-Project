using AutoMapper;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
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
    }

    public async Task<List<ProfessionalResponseDto>> GetAllFilteredAsync(ProfessionalFilterRequest filterRequest)
    {
        List<Professional> professionals = await _uow.Professionals.GetAllAsync(filterRequest);
        return professionals.Select(p => _mapper.Map<ProfessionalResponseDto>(p)).ToList();
    }

    public async Task<ProfessionalResponseDto> GetAsync(Guid id)
    {
        Professional professional = await _uow.Professionals.GetAsync(id) ??
                                    throw new EntityNotFoundException("There is no professional with that id.");
        return _mapper.Map<ProfessionalResponseDto>(professional);
    }

    public async Task<ProfessionalResponseDto> CreateAsync(ProfessionalRequestDto request)
    {
        Professional professional = _mapper.Map<Professional>(request);
        Geolocation geolocation = await _geocodingService.GetGeolocationFromAddressAsync(request.Address) ?? throw new InvalidAddressException("Address is invalid.");
        professional.Geolocation = geolocation;

        _uow.Professionals.Add(professional);
        await _uow.SaveChangesAsync();

        await CreateProfessionalAudiences(professional, request.Audiences);
        await CreateProfessionalPlacesOfIntervention(professional, request.PlacesOfIntervention);
        await CreateProfessionalMissions(professional, request.Missions);

        return _mapper.Map<ProfessionalResponseDto>(professional);
    }

    public async Task<ProfessionalResponseDto> UpdateAsync(Guid id, ProfessionalRequestDto request)
    {
        Professional professional = await _uow.Professionals.GetAsync(id) ??
                                    throw new EntityNotFoundException("There is no professional with that id.");
        professional = _mapper.Map(request, professional);

        _uow.Professionals.Update(professional);
        await _uow.SaveChangesAsync();

        professional.Audiences.ToList().Clear();
        professional.PlacesOfIntervention.ToList().Clear();
        professional.Missions.ToList().Clear();

        await CreateProfessionalAudiences(professional, request.Audiences);
        await CreateProfessionalPlacesOfIntervention(professional, request.PlacesOfIntervention);
        await CreateProfessionalMissions(professional, request.Missions);

        return _mapper.Map<ProfessionalResponseDto>(professional);
    }

    public async Task DeleteAsync(Guid id)
    {
        Professional professional = await _uow.Professionals.GetAsync(id) ??
                                    throw new EntityNotFoundException("There is no professional with that id.");
        _uow.Professionals.Remove(professional);
        await _uow.SaveChangesAsync();
    }

    private async Task CreateProfessionalAudiences(Professional professional,
        IEnumerable<FieldOfInterventionGetRequestDto> requests)
    {
        foreach (FieldOfInterventionGetRequestDto request in requests)
        {
            Audience audience = await _uow.Audiences.GetAsync(request.Id)
                                ?? throw new EntityNotFoundException("There is no audience with that id.");

            ProfessionalAudience professionalAudience = new ProfessionalAudience(professional.Id, audience.Id);
            _uow.ProfessionalAudiences.Add(professionalAudience);
            await _uow.SaveChangesAsync();
        }
    }

    private async Task CreateProfessionalPlacesOfIntervention(Professional professional,
        IEnumerable<FieldOfInterventionGetRequestDto> requests)
    {
        foreach (FieldOfInterventionGetRequestDto request in requests)
        {
            PlaceOfIntervention placeOfIntervention = await _uow.PlacesOfIntervention.GetAsync(request.Id)
                                ?? throw new EntityNotFoundException("There is no place of intervention with that id.");

            ProfessionalPlaceOfIntervention professionalPlaceOfIntervention = new ProfessionalPlaceOfIntervention(professional.Id, placeOfIntervention.Id);
            _uow.ProfessionalPlacesOfIntervention.Add(professionalPlaceOfIntervention);
            await _uow.SaveChangesAsync();
        }
    }

    private async Task CreateProfessionalMissions(Professional professional,
        IEnumerable<FieldOfInterventionGetRequestDto> requests)
    {
        foreach (FieldOfInterventionGetRequestDto request in requests)
        {
            Mission mission = await _uow.Missions.GetAsync(request.Id)
                                ?? throw new EntityNotFoundException("There is no mission with that id.");

            ProfessionalMission professionalMission = new ProfessionalMission(professional.Id, mission.Id);
            _uow.ProfessionalMissions.Add(professionalMission);
            await _uow.SaveChangesAsync();
        }
    }
}
