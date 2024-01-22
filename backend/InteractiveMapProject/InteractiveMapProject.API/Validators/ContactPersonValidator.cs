using FluentValidation;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.API.Validators;

public class ContactPersonValidator : AbstractValidator<ContactPerson>
{
    public ContactPersonValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Contact person name is required.");
        RuleFor(x => x.Function)
            .NotNull().WithMessage("Contact person function is required.");
        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("Contact person phone number is required.")
            .Matches("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$").WithMessage("Contact person phone number must be a valid phone number.");
        RuleFor(x => x.Email)
            .NotNull().WithMessage("Contact person email is required.")
            .EmailAddress().WithMessage("Contact person email must be valid.");
    }
}
