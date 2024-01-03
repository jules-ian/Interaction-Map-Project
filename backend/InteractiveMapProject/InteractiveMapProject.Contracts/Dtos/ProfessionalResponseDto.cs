using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Dtos;

public class ProfessionalResponseDto
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public string EstablishmentType { get; set; } = default!;

    public string ManagementType { get; set; } = default!;

    public Address Address { get; set; } = default!;

    public string PhoneNumber { get; set; } = default!;

    public string Email { get; set; } = default!;

    public ContactPerson ContactPerson { get; set; } = default!;

    public IEnumerable<FieldOfInterventionResponseDto> Audiences { get; set; } = default!;

    public IEnumerable<FieldOfInterventionResponseDto> PlacesOfIntervention { get; set; } = default!;

    public IEnumerable<FieldOfInterventionResponseDto> Missions { get; set; } = default!;

    public Geolocation Geolocation { get; set; } = default!;

    public string? Description { get; set; } = default!;
}
