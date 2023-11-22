namespace InteractiveMapProject.Contracts.Filtering;

public class ProfessionalFilterRequest
{
    public string postalCode { get; set; } = default!;
    public IEnumerable<Guid> audienceIds { get; set; } = default!;
    public IEnumerable<Guid> placeOfInterventionIds { get; set; } = default!;
    public IEnumerable<Guid> missionIds { get; set; } = default!;
}

