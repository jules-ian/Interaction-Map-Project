namespace InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

public class PendingProfessionalAudience
{
    public Guid PendingProfessionalId { get; set; }
    public PendingProfessional PendingProfessional { get; set; } = default!;
    public Guid AudienceId { get; set; }
    public Audience Audience { get; set; } = default!;

    public PendingProfessionalAudience(Guid pendingProfessionalId, Guid audienceId)
    {
        PendingProfessionalId = pendingProfessionalId;
        AudienceId = audienceId;
    }
}
