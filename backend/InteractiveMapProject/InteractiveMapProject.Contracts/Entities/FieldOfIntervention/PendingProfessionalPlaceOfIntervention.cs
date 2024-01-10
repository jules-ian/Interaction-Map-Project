namespace InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

public class PendingProfessionalPlaceOfIntervention
{
    public Guid PendingProfessionalId { get; set; }
    public PendingProfessional PendingProfessional { get; set; } = default!;
    public Guid PlaceOfInterventionId { get; set; }
    public PlaceOfIntervention PlaceOfIntervention { get; set; } = default!;

    public PendingProfessionalPlaceOfIntervention(Guid pendingProfessionalId, Guid placeOfInterventionId)
    {
        PendingProfessionalId = pendingProfessionalId;
        PlaceOfInterventionId = placeOfInterventionId;
    }
}
