namespace InteractiveMapProject.Contracts.Entities;

public class ContactPerson
{
    public string Name { get; set; } = default!;

    public string Function { get; set; } = default!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = default!;
}
