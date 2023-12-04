namespace InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

public class ProfessionalAudience
{
    public Guid ProfessionalId { get; set; }
    public Professional Professional { get; set; } = default!;
    public Guid AudienceId { get; set; }
    public Audience Audience { get; set; } = default!;

    public ProfessionalAudience(
        Guid professionalId,
        Guid audienceId)
    {
        ProfessionalId = professionalId;
        AudienceId = audienceId;
    }
}
