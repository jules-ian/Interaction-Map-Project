using FluentValidation;
using InteractiveMapProject.Contracts.Dtos;

namespace InteractiveMapProject.API.Validators;

public class ValidationDtoValidator : AbstractValidator<ValidationDto>
{
    public ValidationDtoValidator()
    {
        RuleFor(x => x.Approve)
            .NotNull().WithMessage("Approve is required.");
    }
}
