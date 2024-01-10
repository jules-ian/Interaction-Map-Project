using AutoMapper;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Exceptions;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.UoW;

namespace InteractiveMapProject.Services;
public class PlaceOfInterventionService : IPlaceOfInterventionService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public PlaceOfInterventionService(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }
    public async Task<FieldOfInterventionResponseDto> CreateAsync(FieldOfInterventionCreateRequestDto request)
    {
        PlaceOfIntervention placeOfIntervention = _mapper.Map<PlaceOfIntervention>(request);
        _uow.PlacesOfIntervention.Add(placeOfIntervention);
        await _uow.SaveChangesAsync();
        return _mapper.Map<FieldOfInterventionResponseDto>(placeOfIntervention);
    }

    public async Task DeleteAsync(Guid id)
    {
        PlaceOfIntervention placeOfIntervention = await _uow.PlacesOfIntervention.GetAsync(id) ?? throw new EntityNotFoundException("There is no place of intervention with that id.");
        _uow.PlacesOfIntervention.Remove(placeOfIntervention);
        await _uow.SaveChangesAsync();
    }

    public async Task<List<FieldOfInterventionResponseDto>> GetAllAsync()
    {
        List<PlaceOfIntervention> places = await _uow.PlacesOfIntervention.GetAllAsync();
        return places.Select(p => _mapper.Map<FieldOfInterventionResponseDto>(p)).ToList();
    }

    public async Task<FieldOfInterventionResponseDto> GetAsync(Guid id)
    {
        PlaceOfIntervention placeOfIntervention = await _uow.PlacesOfIntervention.GetAsync(id) ?? throw new EntityNotFoundException("There is no place of intervention with that id.");
        return _mapper.Map<FieldOfInterventionResponseDto>(placeOfIntervention);
    }

    public async Task<FieldOfInterventionResponseDto> UpdateAsync(Guid id, FieldOfInterventionCreateRequestDto request)
    {
        PlaceOfIntervention placeOfIntervention = await _uow.PlacesOfIntervention.GetAsync(id) ?? throw new EntityNotFoundException("There is no place of intervention with that id.");
        placeOfIntervention = _mapper.Map(request, placeOfIntervention);
        _uow.PlacesOfIntervention.Update(placeOfIntervention);
        await _uow.SaveChangesAsync();
        return _mapper.Map<FieldOfInterventionResponseDto>(placeOfIntervention);
    }
}
