using FluentValidation;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.API.Validators;

public class ContactPersonValidator : AbstractValidator<ContactPerson>
{
    public ContactPersonValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required.");
        RuleFor(x => x.Function)
            .NotNull().WithMessage("Function is required.");
        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("Phone number is required.");
        RuleFor(x => x.Email)
            .NotNull().WithMessage("Email is required.");
    }
}
