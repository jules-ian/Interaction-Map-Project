using System.ComponentModel.DataAnnotations;

namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public class MapSquare
{
    public double NorthWestLatitude { get; set; } = default!;
    public double NorthWestLongitude { get; set; } = default!;
    public double SouthEastLatitude { get; set; } = default!;
    public double SouthEastLongitude { get; set; } = default!;
}
