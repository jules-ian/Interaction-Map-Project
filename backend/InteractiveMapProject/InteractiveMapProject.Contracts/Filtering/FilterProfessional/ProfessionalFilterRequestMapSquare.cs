using System.ComponentModel.DataAnnotations;

namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public class ProfessionalFilterRequestMapSquare
{
    [Required]
    public double NorthWestLatitude { get; set; } = default!;
    [Required]
    public double NorthWestLongitude { get; set; } = default!;
    [Required]
    public double SouthEastLatitude { get; set; } = default!;
    [Required]
    public double SouthEastLongitude { get; set; } = default!;
}
