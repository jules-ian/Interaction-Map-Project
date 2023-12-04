using AutoMapper;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

namespace InteractiveMapProject.Common.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProfessionalRequestDto, Professional>()
            .ForMember(dest =>
                dest.Geolocation,
                opt => opt.MapFrom(src => new Geolocation()))
            .ForMember(dest =>
                dest.CreationDateTime,
                opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest =>
                dest.Audiences,
                opt => opt.Ignore())
            .ForMember(dest =>
                dest.PlacesOfIntervention,
                opt => opt.Ignore())
            .ForMember(dest =>
                dest.Missions,
                opt => opt.Ignore());
        CreateMap<Professional, ProfessionalResponseDto>()
            .ForMember(dest =>
                    dest.Audiences,
                opt => opt.MapFrom(src => src.Audiences.Select(pa => pa.Audience)))
            .ForMember(dest =>
                    dest.PlacesOfIntervention,
                opt => opt.MapFrom(src => src.PlacesOfIntervention.Select(pp => pp.PlaceOfIntervention)))
            .ForMember(dest =>
                    dest.Missions,
                opt => opt.MapFrom(src => src.Missions.Select(pm => pm.Mission)));

        CreateMap<FieldOfInterventionCreateRequestDto, Audience>();
        CreateMap<Audience, FieldOfInterventionResponseDto>();

        CreateMap<FieldOfInterventionCreateRequestDto, PlaceOfIntervention>();
        CreateMap<PlaceOfIntervention, FieldOfInterventionResponseDto>();

        CreateMap<FieldOfInterventionCreateRequestDto, Mission>();
        CreateMap<Mission, FieldOfInterventionResponseDto>();
    }
}
