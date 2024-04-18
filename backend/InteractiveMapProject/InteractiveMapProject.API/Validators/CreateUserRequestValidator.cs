using FluentValidation;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.API.Validators;

public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserRequestValidator()
    {
        RuleFor(x => x.Email)
            .NotNull().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Email must be valid.");
        RuleFor(x => x.Password)
            .NotNull().WithMessage("Password is required.");
    }
}
