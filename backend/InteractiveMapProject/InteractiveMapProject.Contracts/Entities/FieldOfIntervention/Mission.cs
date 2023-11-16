namespace InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

public class Mission
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public IEnumerable<ProfessionalMission> Professionals { get; set; } = default!;

    public DateTime CreationDateTime { get; set; }
}
