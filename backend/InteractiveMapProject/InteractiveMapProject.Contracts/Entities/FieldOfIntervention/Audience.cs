namespace InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

public class Audience
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public IEnumerable<ProfessionalAudience> Professionals { get; set; } = default!;

    public IEnumerable<PendingProfessionalAudience> PendingProfessionals { get; set; } = default!;

    public DateTime CreationDateTime { get; set; }

    public Audience()
    {
    }

    public Audience(
        Guid id,
        string name)
    {
        Id = id;
        Name = name;
    }
}
