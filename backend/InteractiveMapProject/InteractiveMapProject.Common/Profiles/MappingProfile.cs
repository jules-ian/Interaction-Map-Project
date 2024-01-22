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
            .ForMember(dest => dest.Geolocation, opt => opt.MapFrom(src => new Geolocation()))
            .ForMember(dest => dest.CreationDateTime, opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest => dest.Audiences, opt => opt.Ignore())
            .ForMember(dest => dest.PlacesOfIntervention, opt => opt.Ignore())
            .ForMember(dest => dest.Missions, opt => opt.Ignore());
        CreateMap<Professional, ProfessionalResponseDto>()
            .ForMember(dest => dest.Audiences, opt => opt.MapFrom(src => src.Audiences.Select(pa => pa.Audience)))
            .ForMember(dest => dest.PlacesOfIntervention,
                opt => opt.MapFrom(src => src.PlacesOfIntervention.Select(pp => pp.PlaceOfIntervention)))
            .ForMember(dest => dest.Missions, opt => opt.MapFrom(src => src.Missions.Select(pm => pm.Mission)));

        CreateMap<PendingProfessional, Professional>()
            .ForMember(dest => dest.CreationDateTime, opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.ValidationStatus, opt => opt.Ignore())
            .ForMember(dest => dest.ValidationStatusId, opt => opt.Ignore())
            .ForMember(dest => dest.Audiences, opt => opt.Ignore())
            .ForMember(dest => dest.PlacesOfIntervention, opt => opt.Ignore())
            .ForMember(dest => dest.Missions, opt => opt.Ignore());

        CreateMap<ProfessionalRequestDto, PendingProfessional>()
            .ForMember(dest => dest.Geolocation, opt => opt.MapFrom(src => new Geolocation()))
            .ForMember(dest => dest.CreationDateTime, opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest => dest.Audiences, opt => opt.Ignore())
            .ForMember(dest => dest.PlacesOfIntervention, opt => opt.Ignore())
            .ForMember(dest => dest.Missions, opt => opt.Ignore());
        CreateMap<ProfessionalUpdateRequestDto, PendingProfessional>()
            .ForMember(dest => dest.Geolocation, opt => opt.MapFrom(src => new Geolocation()))
            .ForMember(dest => dest.CreationDateTime, opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest => dest.Audiences, opt => opt.Ignore())
            .ForMember(dest => dest.PlacesOfIntervention, opt => opt.Ignore())
            .ForMember(dest => dest.Missions, opt => opt.Ignore());
        CreateMap<PendingProfessional, PendingProfessionalResponseDto>()
            .ForMember(dest => dest.Audiences, opt => opt.MapFrom(src => src.Audiences.Select(pa => pa.Audience)))
            .ForMember(dest => dest.PlacesOfIntervention,
                opt => opt.MapFrom(src => src.PlacesOfIntervention.Select(pp => pp.PlaceOfIntervention)))
            .ForMember(dest => dest.Missions, opt => opt.MapFrom(src => src.Missions.Select(pm => pm.Mission)));

        CreateMap<ProfessionalRequestDto, ProfessionalUpdateRequestDto>();

        CreateMap<FieldOfInterventionCreateRequestDto, Audience>();
        CreateMap<Audience, IdNameDto>();

        CreateMap<FieldOfInterventionCreateRequestDto, PlaceOfIntervention>();
        CreateMap<PlaceOfIntervention, IdNameDto>();

        CreateMap<FieldOfInterventionCreateRequestDto, Mission>();
        CreateMap<Mission, IdNameDto>();

        CreateMap<ValidationStatus, IdNameDto>();

        CreateMap<PendingProfessional, IdNameDto>();
    }
}
