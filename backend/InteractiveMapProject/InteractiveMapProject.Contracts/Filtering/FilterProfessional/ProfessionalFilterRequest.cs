namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public class ProfessionalFilterRequest : IFilterRequest
{
    public string? PostalCode { get; set; } = default!;
    public IEnumerable<string> Audiences { get; set; } = default!;
    public IEnumerable<string> PlacesOfIntervention { get; set; } = default!;
    public IEnumerable<string> Missions { get; set; } = default!;
}

