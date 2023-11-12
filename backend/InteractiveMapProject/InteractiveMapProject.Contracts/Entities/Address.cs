namespace InteractiveMapProject.Contracts.Entities;

public class Address
{
    public string Street { get; set; } = default!;
    public string City { get; set; } = default!;
    public int PostalCode { get; set; }
}
