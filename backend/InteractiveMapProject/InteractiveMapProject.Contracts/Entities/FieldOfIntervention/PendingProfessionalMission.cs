namespace InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

public class PendingProfessionalMission
{
    public Guid PendingProfessionalId { get; set; }
    public PendingProfessional PendingProfessional { get; set; } = default!;
    public Guid MissionId { get; set; }
    public Mission Mission { get; set; } = default!;

    public PendingProfessionalMission(Guid pendingProfessionalId, Guid missionId)
    {
        PendingProfessionalId = pendingProfessionalId;
        MissionId = missionId;
    }
}
