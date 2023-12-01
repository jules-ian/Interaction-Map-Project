using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Dtos;

public class ProfessionalRequestDto
{
    public string Name { get; set; } = default!;

    public string EstablishmentType { get; set; } = default!;

    public string ManagementType { get; set; } = default!;

    public Address Address { get; set; } = default!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = default!;

    public ContactPerson ContactPerson { get; set; } = default!;

    public IEnumerable<AudienceRequestDto> Audiences { get; set; } = default!;

    public IEnumerable<PlaceOfInterventionRequestDto> PlacesOfIntervention { get; set; } = default!;

    public IEnumerable<MissionRequestDto> Missions { get; set; } = default!;

    public string? Description { get; set; } = default!;
}
