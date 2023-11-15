namespace InteractiveMapProject.Contracts.Entities;

public class FieldOfIntervention
{
    public IEnumerable<Audience> Audiences { get; set; } = default!;

    public IEnumerable<PlaceOfIntervention> PlacesOfIntervention { get; set; } = default!;

    public IEnumerable<Mission> Missions { get; set; } = default!;
}
