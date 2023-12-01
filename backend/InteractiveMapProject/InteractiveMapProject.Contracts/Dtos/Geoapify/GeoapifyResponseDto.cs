namespace InteractiveMapProject.Contracts.Dtos.Geoapify;

public class GeoapifyResponseDto
{
    public string Type { get; set; } = default!;
    public IEnumerable<GeoapifyFeatureDto> Features { get; set; } = default!;
    public GeoapifyQueryDto Query { get; set; } = default!;
}
