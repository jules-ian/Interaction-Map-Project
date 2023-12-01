namespace InteractiveMapProject.Contracts.Dtos.Geoapify;

public class GeoapifyQueryDto
{
    public string Text { get; set; } = default!;
    public GeoapifyParsedDto Parsed { get; set; } = default!;
}
