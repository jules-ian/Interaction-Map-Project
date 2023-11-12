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
                dest.CreationDateTime,
                opt => opt.MapFrom(src => DateTime.Now));
        CreateMap<Professional, ProfessionalResponseDto>();
    }
}
