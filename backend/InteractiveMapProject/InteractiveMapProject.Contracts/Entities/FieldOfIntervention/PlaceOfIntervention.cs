namespace InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

public class PlaceOfIntervention
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public IEnumerable<ProfessionalPlaceOfIntervention> Professionals { get; set; } = default!;

    public DateTime CreationDateTime { get; set; }

    public PlaceOfIntervention()
    {
    }

    public PlaceOfIntervention(
        Guid id,
        string name)
    {
        Id = id;
        Name = name;
    }
}
