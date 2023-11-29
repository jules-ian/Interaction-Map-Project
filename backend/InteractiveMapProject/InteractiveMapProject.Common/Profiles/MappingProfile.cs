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
                opt => opt.MapFrom(src => DateTime.Now));
        CreateMap<Professional, ProfessionalResponseDto>();

        CreateMap<AudienceRequestDto, Audience>();
        CreateMap<Audience, AudienceResponseDto>();

        CreateMap<PlaceOfInterventionRequestDto, PlaceOfIntervention>();
        CreateMap<PlaceOfIntervention, PlaceOfInterventionResponseDto>();

        CreateMap<MissionRequestDto, Mission>();
        CreateMap<Mission, MissionResponseDto>();
    }
}
