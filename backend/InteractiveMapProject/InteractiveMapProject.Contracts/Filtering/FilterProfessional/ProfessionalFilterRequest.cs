namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public class ProfessionalFilterRequest : IFilterRequest
{
    public string? PostalCode { get; set; } = default!;
    public IEnumerable<Guid>? Audiences { get; set; } = default!;
    public IEnumerable<Guid>? PlacesOfIntervention { get; set; } = default!;
    public IEnumerable<Guid>? Missions { get; set; } = default!;
}

