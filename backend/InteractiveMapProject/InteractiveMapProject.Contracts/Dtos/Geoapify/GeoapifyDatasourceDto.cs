namespace InteractiveMapProject.Contracts.Dtos.Geoapify;

public class GeoapifyDatasourceDto
{
    public string SourceName { get; set; } = default!;
    public string Attribution { get; set; } = default!;
    public string License { get; set; } = default!;
    public string Url { get; set; } = default!;
}
