namespace InteractiveMapProject.Contracts.Dtos.Geoapify;

public class GeoapifyTimezoneDto
{
    public string Name { get; set; } = default!;
    public string NameAlt { get; set; } = default!;
    public string OffsetSTD { get; set; } = default!;
    public int OffsetSTDSeconds { get; set; }
    public string OffsetDST { get; set; } = default!;
    public int OffsetDSTSeconds { get; set; }
    public string AbbrevationSTD { get; set; } = default!;
    public string AbbrevationDST { get; set; } = default!;
}
