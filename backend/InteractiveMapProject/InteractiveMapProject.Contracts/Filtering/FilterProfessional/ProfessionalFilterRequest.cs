namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public class ProfessionalFilterRequest : IFilterRequest
{
    public string? PostalCode { get; set; } = default!;
    public IEnumerable<Guid> AudienceIds { get; set; } = default!;
    public IEnumerable<Guid> PlaceOfInterventionIds { get; set; } = default!;
    public IEnumerable<Guid> MissionIds { get; set; } = default!;
}

