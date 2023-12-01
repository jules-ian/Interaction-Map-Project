using AutoMapper;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Exceptions;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.UoW;

namespace InteractiveMapProject.Services;
public class MissionService : IMissionService
{

    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public MissionService(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }

    public async Task<FieldOfInterventionResponseDto> CreateAsync(FieldOfInterventionCreateRequestDto request)
    {
        Mission mission = _mapper.Map<Mission>(request);
        _uow.Missions.Add(mission);
        await _uow.SaveChangesAsync();
        return _mapper.Map<FieldOfInterventionResponseDto>(mission);
    }

    public async Task DeleteAsync(Guid id)
    {
        Mission mission = await _uow.Missions.GetAsync(id) ?? throw new EntityNotFoundException("There is no mission with that id.");
        _uow.Missions.Remove(mission);
        await _uow.SaveChangesAsync();
    }

    public async Task<List<FieldOfInterventionResponseDto>> GetAllAsync()
    {
        List<Mission> missions = await _uow.Missions.GetAllAsync();
        return missions.Select(m => _mapper.Map<FieldOfInterventionResponseDto>(m)).ToList();
    }

    public async Task<FieldOfInterventionResponseDto> GetAsync(Guid id)
    {
        Mission mission = await _uow.Missions.GetAsync(id) ?? throw new EntityNotFoundException("There is no mission with that id.");
        return _mapper.Map<FieldOfInterventionResponseDto>(mission);
    }

    public async Task<FieldOfInterventionResponseDto> UpdateAsync(Guid id, FieldOfInterventionCreateRequestDto request)
    {
        Mission mission = await _uow.Missions.GetAsync(id) ?? throw new EntityNotFoundException("There is no mission with that id.");
        mission = _mapper.Map(request, mission);
        _uow.Missions.Update(mission);
        await _uow.SaveChangesAsync();
        return _mapper.Map<FieldOfInterventionResponseDto>(mission);
    }
}
