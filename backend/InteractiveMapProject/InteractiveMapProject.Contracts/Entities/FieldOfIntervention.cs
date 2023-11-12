using InteractiveMapProject.Contracts.Enums;

namespace InteractiveMapProject.Contracts.Entities;

public class FieldOfIntervention
{
    public Audience Audience { get; set; }

    public string SectorOfIntervetion { get; set; } = default!;

    public string PlaceOfIntervention { get; set; } = default!;
}
