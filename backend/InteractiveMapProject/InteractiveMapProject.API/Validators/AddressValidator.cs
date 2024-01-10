using FluentValidation;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.API.Validators;

public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator()
    {
        RuleFor(x => x.Street)
            .NotNull().WithMessage("Street is required.");
        RuleFor(x => x.City)
            .NotNull().WithMessage("City is required.");
        RuleFor(x => x.PostalCode)
            .NotNull().WithMessage("Postal code is required.");
    }
}
