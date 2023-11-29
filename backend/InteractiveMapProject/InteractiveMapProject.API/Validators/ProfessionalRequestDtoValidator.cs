using FluentValidation;
using InteractiveMapProject.API.Validators.FieldOfIntervetion;
using InteractiveMapProject.Contracts.Dtos;

namespace InteractiveMapProject.API.Validators;

public class ProfessionalRequestDtoValidator : AbstractValidator<ProfessionalRequestDto>
{
    public ProfessionalRequestDtoValidator()
    {
        RuleFor(x => x.ServiceName)
            .NotNull().WithMessage("Service name is required.");
        RuleFor(x => x.Address)
            .NotNull().WithMessage("Address is required.")
            .SetValidator(new AddressValidator());
        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("Phone number is required.");
        RuleFor(x => x.Email)
            .NotNull().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Email must be valid.");
        RuleFor(x => x.ContactPerson)
            .NotNull().WithMessage("Contact person is required.")
            .SetValidator(new ContactPersonValidator());
        RuleForEach(x => x.Audiences)
            .NotNull().WithMessage("Audience is required.")
            .SetValidator(new AudienceRequestDtoValidator());
        RuleForEach(x => x.PlacesOfIntervention)
            .NotNull().WithMessage("Place of intervetion is required.")
            .SetValidator(new PlaceOfInterventionRequestDtoValidator());
        RuleForEach(x => x.Missions)
            .NotNull().WithMessage("Mission is required.")
            .SetValidator(new MissionRequestDtoValidator());
    }
}
