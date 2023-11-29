using AutoMapper;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Entities;

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
                opt => opt.Ignore())
            .ForMember(dest =>
                dest.PlacesOfIntervention,
                opt => opt.Ignore())
            .ForMember(dest =>
                dest.Missions,
                opt => opt.Ignore());
    }
}
