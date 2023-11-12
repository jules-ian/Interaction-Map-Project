using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Enums;

namespace InteractiveMapProject.Contracts.Dtos;

public class ProfessionalResponseDto
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

    public Mission Mission { get; set; } = default!;

    public Geolocation Geolocation { get; set; } = default!;

    public string? Description { get; set; } = default!;
}
