namespace InteractiveMapProject.Contracts.Entities;

public class ValidationStatus
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public IEnumerable<Professional> Professionals { get; set; } = default!;

    public IEnumerable<PendingProfessional> PendingProfessionals { get; set; } = default!;

    public ValidationStatus(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
