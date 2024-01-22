using FluentValidation;
using InteractiveMapProject.API.Validators.FieldOfIntervetion;
using InteractiveMapProject.Contracts.Dtos;

namespace InteractiveMapProject.API.Validators;

public class ProfessionalRequestDtoValidator : AbstractValidator<ProfessionalRequestDto>
{
    public ProfessionalRequestDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required.");
        RuleFor(x => x.EstablishmentType)
            .NotNull().WithMessage("Establishment type is required.");
        RuleFor(x => x.ManagementType)
            .NotNull().WithMessage("Management type is required.");
        RuleFor(x => x.Address)
            .NotNull().WithMessage("Address is required.")
            .SetValidator(new AddressValidator());
        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("Phone number is required.")
            .Matches("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$")
            .WithMessage("Phone number must be a valid phone number.");
        RuleFor(x => x.Email)
            .NotNull().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Email must be valid.");
        RuleFor(x => x.ContactPerson)
            .NotNull().WithMessage("Contact person is required.")
            .SetValidator(new ContactPersonValidator());
        RuleFor(x => x.Audiences)
            .NotNull().WithMessage("Audiences are required.");
        RuleForEach(x => x.Audiences)
            .NotNull().WithMessage("Audience is required.")
            .SetValidator(new FieldOfInterventionGetRequestDtoValidator());
        RuleFor(x => x.PlacesOfIntervention)
            .NotNull().WithMessage("Places of intervention are required.");
        RuleForEach(x => x.PlacesOfIntervention)
            .NotNull().WithMessage("Place of intervetion is required.")
            .SetValidator(new FieldOfInterventionGetRequestDtoValidator());
        RuleFor(x => x.Missions)
            .NotNull().WithMessage("Missions are required.");
        RuleForEach(x => x.Missions)
            .NotNull().WithMessage("Mission is required.")
            .SetValidator(new FieldOfInterventionGetRequestDtoValidator());
    }
}
