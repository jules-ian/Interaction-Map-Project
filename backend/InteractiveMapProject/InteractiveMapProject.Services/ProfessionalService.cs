using AutoMapper;
using InteractiveMapProject.Contracts.Dtos;
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

    public async Task<ProfessionalResponseDto> GetAsync(Guid statusId, Guid id)
    {
        ValidationStatus validationStatus = await _uow.ValidationStatuses.GetAsync(statusId) ??
                                            throw new EntityNotFoundException(
                                                "There is no validation status with that id.");

        if (!validationStatus.Name.Equals("Approved"))
        {
            PendingProfessional pendingProfessional = await _uow.PendingProfessionals.GetAsync(id) ??
                                                      throw new EntityNotFoundException(
                                                          "There is no pending professional with that id.");
            return _mapper.Map<ProfessionalResponseDto>(pendingProfessional);
        }

        return await GetAsync(id);
    }

    public async Task ValidateAsync(Guid pendingProfessionalId, ValidationDto validationDto)
    {
        PendingProfessional pendingProfessional = await _uow.PendingProfessionals.GetAsync(pendingProfessionalId) ??
                                                  throw new EntityNotFoundException(
                                                      "There is no pending professional with that id.");

        if (validationDto.Approve && pendingProfessional.ValidationStatus.Name.Equals("Waiting After Creation"))
        {
            ValidationStatus validationStatus =
                await _uow.ValidationStatuses.FirstOrDefaultAsync(vs => vs.Name == "Approved") ??
                throw new EntityNotFoundException("There is no validation status for your action.");

            Professional professional = _mapper.Map<Professional>(pendingProfessional);
            professional.ValidationStatusId = validationStatus.Id;

            _uow.Professionals.Add(professional);
            await _uow.SaveChangesAsync();

            await CreateProfessionalAudiences(professional,
                pendingProfessional.Audiences.Select(p => p.Audience).ToList());
            await CreateProfessionalPlacesOfIntervention(professional,
                pendingProfessional.PlacesOfIntervention.Select(p => p.PlaceOfIntervention).ToList());
            await CreateProfessionalMissions(professional,
                pendingProfessional.Missions.Select(p => p.Mission).ToList());
        }
        else if (validationDto.Approve && pendingProfessional.ValidationStatus.Name.Equals("Waiting After Update"))
        {
            Professional professional =
                await _uow.Professionals.GetAsync(pendingProfessional.ProfessionalId.GetValueOrDefault()) ??
                throw new EntityNotFoundException("There is no professional with that id.");

            professional = _mapper.Map(pendingProfessional, professional);
            _uow.Professionals.Update(professional);
            await _uow.SaveChangesAsync();

            await DeleteProfessionalAudiences(professional);
            await DeleteProfessionalPlacesOfIntervention(professional);
            await DeleteProfessionalMissions(professional);

            await CreateProfessionalAudiences(professional,
                pendingProfessional.Audiences.Select(p => p.Audience).ToList());
            await CreateProfessionalPlacesOfIntervention(professional,
                pendingProfessional.PlacesOfIntervention.Select(p => p.PlaceOfIntervention).ToList());
            await CreateProfessionalMissions(professional,
                pendingProfessional.Missions.Select(p => p.Mission).ToList());
        }

        _uow.PendingProfessionals.Remove(pendingProfessional);
        await _uow.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        Professional professional = await _uow.Professionals.GetAsync(id) ??
                                    throw new EntityNotFoundException("There is no professional with that id.");

        if (professional.PendingProfessionals.Count() != 0)
        {
            PendingProfessional pendingProfessional = professional.PendingProfessionals.ToList().First();
            _uow.PendingProfessionals.Remove(pendingProfessional);
        }

        _uow.Professionals.Remove(professional);
        await _uow.SaveChangesAsync();
    }

    private async Task CreateProfessionalAudiences(Professional professional, List<Audience> audiences)
    {
        foreach (Audience a in audiences)
        {
            Audience audience = await _uow.Audiences.GetAsync(a.Id)
                                ?? throw new EntityNotFoundException("There is no audience with that id.");

            ProfessionalAudience professionalAudience = new ProfessionalAudience(professional.Id, audience.Id);
            _uow.ProfessionalAudiences.Add(professionalAudience);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task CreateProfessionalPlacesOfIntervention(Professional professional,
        List<PlaceOfIntervention> places)
    {
        foreach (PlaceOfIntervention p in places)
        {
            PlaceOfIntervention placeOfIntervention = await _uow.PlacesOfIntervention.GetAsync(p.Id)
                                                      ?? throw new EntityNotFoundException(
                                                          "There is no place of intervention with that id.");

            ProfessionalPlaceOfIntervention professionalPlaceOfIntervention =
                new ProfessionalPlaceOfIntervention(professional.Id, placeOfIntervention.Id);
            _uow.ProfessionalPlacesOfIntervention.Add(professionalPlaceOfIntervention);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task CreateProfessionalMissions(Professional professional, List<Mission> missions)
    {
        foreach (Mission m in missions)
        {
            Mission mission = await _uow.Missions.GetAsync(m.Id)
                              ?? throw new EntityNotFoundException("There is no mission with that id.");

            ProfessionalMission professionalMission = new ProfessionalMission(professional.Id, mission.Id);
            _uow.ProfessionalMissions.Add(professionalMission);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task DeleteProfessionalAudiences(Professional professional)
    {
        foreach (var professionalAudience in professional.Audiences)
        {
            _uow.ProfessionalAudiences.Remove(professionalAudience);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task DeleteProfessionalPlacesOfIntervention(Professional professional)
    {
        foreach (var professionalPlaceOfIntervention in professional.PlacesOfIntervention)
        {
            _uow.ProfessionalPlacesOfIntervention.Remove(professionalPlaceOfIntervention);
        }

        await _uow.SaveChangesAsync();
    }

    private async Task DeleteProfessionalMissions(Professional professional)
    {
        foreach (var professionalMission in professional.Missions)
        {
            _uow.ProfessionalMissions.Remove(professionalMission);
        }

        await _uow.SaveChangesAsync();
    }
}
