using AutoMapper;
using DefaultNamespace;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Exceptions;
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

    public async Task<MissionResponseDto> CreateAsync(MissionRequestDto request)
    {
        Mission mission = _mapper.Map<Mission>(request);
        _uow.Missions.Add(mission);
        await _uow.SaveChangesAsync();
        return _mapper.Map<MissionResponseDto>(mission);
    }

    public async Task DeleteAsync(Guid id)
    {
        Mission mission = await _uow.Missions.GetAsync(id) ?? throw new EntityNotFoundException("There is no mission with that id.");
        _uow.Missions.Remove(mission);
        await _uow.SaveChangesAsync();
    }

    public async Task<List<MissionResponseDto>> GetAllAsync()
    {
        List<Mission> missions = await _uow.Missions.GetAllAsync();
        return missions.Select(m => _mapper.Map<MissionResponseDto>(m)).ToList();
    }

    public async Task<MissionResponseDto> GetAsync(Guid id)
    {
        Mission mission = await _uow.Missions.GetAsync(id) ?? throw new EntityNotFoundException("There is no mission with that id.");
        return _mapper.Map<MissionResponseDto>(mission);
    }

    public async Task<MissionResponseDto> UpdateAsync(Guid id, MissionRequestDto request)
    {
        Mission mission = await _uow.Missions.GetAsync(id) ?? throw new EntityNotFoundException("There is no mission with that id.");
        mission = _mapper.Map(request, mission);
        _uow.Missions.Update(mission);
        await _uow.SaveChangesAsync();
        return _mapper.Map<MissionResponseDto>(mission);
    }
}
