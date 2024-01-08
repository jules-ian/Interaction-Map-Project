using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

namespace InteractiveMapProject.Contracts.Entities;

public class PendingProfessional
{
    public Guid Id { get; set; }

    public Guid? ProfessionalId { get; set; }

    public Professional Professional { get; set; } = default!;

    public string Name { get; set; } = default!;

    public string EstablishmentType { get; set; } = default!;

    public string ManagementType { get; set; } = default!;

    public Address Address { get; set; } = default!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = default!;

    public ContactPerson ContactPerson { get; set; } = default!;

    public IEnumerable<PendingProfessionalAudience> Audiences { get; set; } = new List<PendingProfessionalAudience> { };

    public IEnumerable<PendingProfessionalPlaceOfIntervention> PlacesOfIntervention { get; set; } =
        new List<PendingProfessionalPlaceOfIntervention> { };

    public IEnumerable<PendingProfessionalMission> Missions { get; set; } = new List<PendingProfessionalMission> { };

    public Geolocation Geolocation { get; set; } = default!;

    public Guid ValidationStatusId { get; set; }

    public ValidationStatus? ValidationStatus { get; set; } = default!;

    public string? Description { get; set; }

    public DateTime CreationDateTime { get; set; }
}
