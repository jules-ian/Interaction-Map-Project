using FluentValidation;
using InteractiveMapProject.Contracts.Dtos;

namespace InteractiveMapProject.API.Validators;

public class ProfessionalRequestDtoValidator : AbstractValidator<ProfessionalRequestDto>
{
    public ProfessionalRequestDtoValidator()
    {
        RuleFor(x => x.ServiceName)
            .NotNull().WithMessage("Service name is required.");
        RuleFor(x => x.Address)
            .NotNull().WithMessage("Address is required.");
        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("Phone number is required.");
        RuleFor(x => x.Email)
            .NotNull().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Email must be valid.");
        RuleFor(x => x.ResourcePersonName)
            .NotNull().WithMessage("Name of the resource person is required.");
        RuleFor(x => x.Function)
            .NotNull().WithMessage("Function is required.");
        RuleFor(x => x.ContactPersonPhoneNumber)
            .NotNull().WithMessage("Phone number of the resource person is required.");
        RuleFor(x => x.ContactPersonEmail)
            .NotNull().WithMessage("Email of the resource person is required.");
        RuleFor(x => x.FieldOfIntervention)
            .NotNull().WithMessage("Field of intervention is required.");
        RuleFor(x => x.Mission)
            .NotNull().WithMessage("Mission is required.");
    }
}
