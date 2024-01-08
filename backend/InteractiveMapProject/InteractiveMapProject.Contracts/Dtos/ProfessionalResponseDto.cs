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

    public IEnumerable<IdNameDto> Audiences { get; set; } = default!;

    public IEnumerable<IdNameDto> PlacesOfIntervention { get; set; } = default!;

    public IEnumerable<IdNameDto> Missions { get; set; } = default!;

    public Geolocation Geolocation { get; set; } = default!;

    public string? Description { get; set; }

    public IdNameDto ValidationStatus { get; set; } = default!;

    public IEnumerable<IdNameDto> PendingProfessionals { get; set; } = default!;
}
