namespace InteractiveMapProject.Contracts.Entities;

public class Professional
{
    public Guid Id { get; set; }

    public string ServiceName { get; set; } = default!;

    public Address Address { get; set; } = default!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = default!;

    public string ResourcePersonName { get; set; } = default!;

    public string Function { get; set; } = default!;

    public int ContactPersonPhoneNumber { get; set; }

    public string ContactPersonEmail { get; set; } = default!;

    public FieldOfIntervention FieldOfIntervention { get; set; } = default!;

    public Geolocation Geolocation { get; set; } = default!;

    public string? Description { get; set; } = default!;

    public DateTime CreationDateTime { get; set; }
}
