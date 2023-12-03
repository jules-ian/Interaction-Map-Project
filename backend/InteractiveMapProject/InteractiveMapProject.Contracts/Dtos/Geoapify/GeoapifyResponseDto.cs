namespace InteractiveMapProject.Contracts.Dtos.Geoapify;

public class GeoapifyResponseDto
{
    public IEnumerable<GeoapifyFeatureDto> Features { get; set; } = default!;
}
