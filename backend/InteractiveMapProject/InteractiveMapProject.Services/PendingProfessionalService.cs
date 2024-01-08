using AutoMapper;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Exceptions;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.UoW;

namespace InteractiveMapProject.Services;

public class PendingProfessionalService : IPendingProfessionalService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;
    private readonly IGeocodingService _geocodingService;

    public PendingProfessionalService(IUnitOfWork uow, IMapper mapper, IGeocodingService geocodingService)
    {
        _uow = uow;
        _mapper = mapper;
        _geocodingService = geocodingService;
    }

    public async Task<List<PendingProfessionalResponseDto>> GetAllAsync()
    {
        List<PendingProfessional> pendingProfessionals = await _uow.PendingProfessionals.GetAllAsync();
        return pendingProfessionals.Select(p => _mapper.Map<PendingProfessionalResponseDto>(p)).ToList();
    }

    public async Task<PendingProfessionalResponseDto> GetAsync(Guid id)
    {
        PendingProfessional pendingProfessional = await _uow.PendingProfessionals.GetAsync(id) ??
                                                  throw new EntityNotFoundException(
                                                      "There is no pending professional with that id.");
        return _mapper.Map<PendingProfessionalResponseDto>(pendingProfessional);
    }

    public async Task<PendingProfessionalResponseDto> CreateAsync(ProfessionalRequestDto request)
    {
        PendingProfessional pendingProfessional = _mapper.Map<PendingProfessional>(request);

        Geolocation geolocation = await _geocodingService.GetGeolocationFromAddressAsync(request.Address) ??
                                  throw new InvalidAddressException("Address is invalid.");
        pendingProfessional.Geolocation = geolocation;

        ValidationStatus validationStatus =
            await _uow.ValidationStatuses.FirstOrDefaultAsync(vs => vs.Name.Equals("Waiting After Creation")) ??
            throw new EntityNotFoundException("There is no validation status for your action.");
        pendingProfessional.ValidationStatus = validationStatus;

        _uow.PendingProfessionals.Add(pendingProfessional);
        await _uow.SaveChangesAsync();

        await CreatePendingProfessionalAudiences(pendingProfessional, request.Audiences);
        await CreatePendingProfessionalPlacesOfIntervention(pendingProfessional, request.PlacesOfIntervention);
        await CreatePendingProfessionalMissions(pendingProfessional, request.Missions);

        return _mapper.Map<PendingProfessionalResponseDto>(pendingProfessional);
    }

    public async Task<PendingProfessionalResponseDto> UpdateAsync(Guid professionalId, ProfessionalRequestDto request)
    {
        PendingProfessional pendingProfessional =
            await _uow.PendingProfessionals.FirstOrDefaultAsync(p => p.ProfessionalId.Equals(professionalId)) ??
            new PendingProfessional();

        ProfessionalUpdateRequestDto updateRequest = _mapper.Map<ProfessionalUpdateRequestDto>(request);
        updateRequest.ProfessionalId = professionalId;

        pendingProfessional = _mapper.Map(updateRequest, pendingProfessional);

        Geolocation geolocation = await _geocodingService.GetGeolocationFromAddressAsync(request.Address) ??
                                  throw new InvalidAddressException("Address is invalid.");
        pendingProfessional.Geolocation = geolocation;

        ValidationStatus validationStatus =
            await _uow.ValidationStatuses.FirstOrDefaultAsync(vs => vs.Name.Equals("Waiting After Update")) ??
            throw new EntityNotFoundException("There is no validation status for your action.");
        pendingProfessional.ValidationStatus = validationStatus;

        if (pendingProfessional.Id.Equals(null))
        {
            _uow.PendingProfessionals.Add(pendingProfessional);
            await _uow.SaveChangesAsync();
        }
        else
        {
            _uow.PendingProfessionals.Update(pendingProfessional);
            await _uow.SaveChangesAsync();

            await DeletePendingProfessionalAudiences(pendingProfessional);
            await DeletePendingProfessionalPlacesOfIntervention(pendingProfessional);
            await DeletePendingProfessionalMissions(pendingProfessional);
        }

        await CreatePendingProfessionalAudiences(pendingProfessional, request.Audiences);
        await CreatePendingProfessionalPlacesOfIntervention(pendingProfessional, request.PlacesOfIntervention);
        await CreatePendingProfessionalMissions(pendingProfessional, request.Missions);

        return _mapper.Map<PendingProfessionalResponseDto>(pendingProfessional);
    }

    public async Task DeleteAsync(Guid id)
    {
        PendingProfessional pendingProfessional = await _uow.PendingProfessionals.GetAsync(id) ??
                                                  throw new EntityNotFoundException(
                                                      "There is no pending professional with that id.");

        _uow.PendingProfessionals.Remove(pendingProfessional);
        await _uow.SaveChangesAsync();
    }

    private async Task CreatePendingProfessionalAudiences(PendingProfessional pendingProfessional,
        IEnumerable<FieldOfInterventionGetRequestDto> requests)
    {
        foreach (FieldOfInterventionGetRequestDto request in requests)
        {
            Audience audience = await _uow.Audiences.GetAsync(request.Id)
                                ?? throw new EntityNotFoundException("There is no audience with that id.");

            PendingProfessionalAudience pendingProfessionalAudience =
                new PendingProfessionalAudience(pendingProfessional.Id, audience.Id);
            _uow.PendingProfessionalAudiences.Add(pendingProfessionalAudience);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task CreatePendingProfessionalPlacesOfIntervention(PendingProfessional pendingProfessional,
        IEnumerable<FieldOfInterventionGetRequestDto> requests)
    {
        foreach (FieldOfInterventionGetRequestDto request in requests)
        {
            PlaceOfIntervention placeOfIntervention = await _uow.PlacesOfIntervention.GetAsync(request.Id)
                                                      ?? throw new EntityNotFoundException(
                                                          "There is no place of intervention with that id.");

            PendingProfessionalPlaceOfIntervention pendingProfessionalPlaceOfIntervention =
                new PendingProfessionalPlaceOfIntervention(pendingProfessional.Id, placeOfIntervention.Id);
            _uow.PendingProfessionalPlacesOfIntervention.Add(pendingProfessionalPlaceOfIntervention);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task CreatePendingProfessionalMissions(PendingProfessional pendingProfessional,
        IEnumerable<FieldOfInterventionGetRequestDto> requests)
    {
        foreach (FieldOfInterventionGetRequestDto request in requests)
        {
            Mission mission = await _uow.Missions.GetAsync(request.Id)
                              ?? throw new EntityNotFoundException("There is no mission with that id.");

            PendingProfessionalMission pendingProfessionalMission =
                new PendingProfessionalMission(pendingProfessional.Id, mission.Id);
            _uow.PendingProfessionalMissions.Add(pendingProfessionalMission);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task DeletePendingProfessionalAudiences(PendingProfessional pendingProfessional)
    {
        foreach (var pendingProfessionalAudience in pendingProfessional.Audiences)
        {
            _uow.PendingProfessionalAudiences.Remove(pendingProfessionalAudience);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task DeletePendingProfessionalPlacesOfIntervention(PendingProfessional pendingProfessional)
    {
        foreach (var pendingProfessionalPlaceOfIntervention in pendingProfessional.PlacesOfIntervention)
        {
            _uow.PendingProfessionalPlacesOfIntervention.Remove(pendingProfessionalPlaceOfIntervention);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task DeletePendingProfessionalMissions(PendingProfessional pendingProfessional)
    {
        foreach (var pendingProfessionalMission in pendingProfessional.Missions)
        {
            _uow.PendingProfessionalMissions.Remove(pendingProfessionalMission);
        }

        await _uow.SaveChangesAsync();
    }
}
