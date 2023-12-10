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

    public IEnumerable<ProfessionalAudience> Audiences { get; set; } = new List<ProfessionalAudience> { };

    public IEnumerable<ProfessionalPlaceOfIntervention> PlacesOfIntervention { get; set; } = new List<ProfessionalPlaceOfIntervention> { };

    public IEnumerable<ProfessionalMission> Missions { get; set; } = new List<ProfessionalMission> { };

    public Geolocation Geolocation { get; set; } = default!;

    public string? Description { get; set; } = default!;

    public DateTime CreationDateTime { get; set; }
}
