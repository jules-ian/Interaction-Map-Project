namespace InteractiveMapProject.Contracts.Dtos.Geoapify;

public class GeoapifyFeatureDto
{
    public string Type { get; set; } = default!;
    public GeoapifyPropertiesDto Properties { get; set; } = default!;
    public GeoapifyGeometryDto Geometry { get; set; } = default!;
    public IEnumerable<double> Bbox { get; set; } = default!;
}

