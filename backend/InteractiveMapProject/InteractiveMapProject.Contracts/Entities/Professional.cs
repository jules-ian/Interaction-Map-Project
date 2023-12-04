using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

namespace InteractiveMapProject.Contracts.Entities;

public class Professional
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public string EstablishmentType { get; set; } = default!;

    public string ManagementType { get; set; } = default!;

    public Address Address { get; set; } = default!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = default!;

    public ContactPerson ContactPerson { get; set; } = default!;

    public List<ProfessionalAudience> Audiences { get; set; } = default!;

    public List<ProfessionalPlaceOfIntervention> PlacesOfIntervention { get; set; } = default!;

    public List<ProfessionalMission> Missions { get; set; } = default!;

    public Geolocation Geolocation { get; set; } = default!;

    public string? Description { get; set; } = default!;

    public DateTime CreationDateTime { get; set; }
}
