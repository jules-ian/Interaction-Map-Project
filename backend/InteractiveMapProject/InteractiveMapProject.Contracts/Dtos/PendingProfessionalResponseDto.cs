using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Dtos;

public class PendingProfessionalResponseDto
{
    public Guid Id { get; set; }

    public Guid ProfessionalId { get; set; } = default;

    public string Name { get; set; } = default!;

    public string EstablishmentType { get; set; } = default!;

    public string ManagementType { get; set; } = default!;

    public Address Address { get; set; } = default!;

    public string PhoneNumber { get; set; }

    public string Email { get; set; } = default!;

    public ContactPerson ContactPerson { get; set; } = default!;

    public IEnumerable<IdNameDto> Audiences { get; set; } = default!;

    public IEnumerable<IdNameDto> PlacesOfIntervention { get; set; } = default!;

    public IEnumerable<IdNameDto> Missions { get; set; } = default!;

    public Geolocation Geolocation { get; set; } = default!;

    public string? Description { get; set; }

    public IdNameDto ValidationStatus { get; set; } = default!;
}
