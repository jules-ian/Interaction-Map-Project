namespace InteractiveMapProject.Contracts.Entities;

public class PlaceOfIntervention
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public IEnumerable<Professional> Professionals { get; set; } = default!;
}
