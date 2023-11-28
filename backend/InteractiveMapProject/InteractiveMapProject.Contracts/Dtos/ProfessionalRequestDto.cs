using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Dtos;

public class ProfessionalRequestDto
{
    public string ServiceName { get; set; } = default!;

    public Address Address { get; set; } = default!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = default!;

    public string ResourcePersonName { get; set; } = default!;

    public string Function { get; set; } = default!;

    public int ContactPersonPhoneNumber { get; set; }

    public string ContactPersonEmail { get; set; } = default!;

    public IEnumerable<AudienceRequestDto> Audiences { get; set; } = default!;

    public IEnumerable<PlaceOfInterventionRequestDto> PlacesOfIntervention { get; set; } = default!;

    public IEnumerable<MissionRequestDto> Missions { get; set; } = default!;

    public string? Description { get; set; } = default!;
}
