namespace InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

public class ProfessionalMission
{
    public Guid ProfessionalId { get; set; }
    public Professional Professional { get; set; } = default!;
    public Guid MissionId { get; set; }
    public Mission Mission { get; set; } = default!;
}
