namespace InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

public class ProfessionalPlaceOfIntervention
{
    public Guid ProfessionalId { get; set; }
    public Professional Professional { get; set; } = default!;
    public Guid PlaceOfInterventionId { get; set; }
    public PlaceOfIntervention PlaceOfIntervention { get; set; } = default!;
}
