namespace InteractiveMapProject.Contracts.Dtos.Geoapify;

public class GeoapifyGeometryDto
{
    public string Type { get; set; } = default!;
    public IEnumerable<double> Coordinates { get; set; } = default!;

}
