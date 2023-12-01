namespace InteractiveMapProject.Contracts.Dtos.Geoapify;

public class GeoapifyParsedDto
{
    public string HouseNumber { get; set; } = default!;
    public string Street { get; set; } = default!;
    public string Postcode { get; set; } = default!;
    public string City { get; set; } = default!;
    public string ExpectedType { get; set; } = default!;
}
