using FluentValidation;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.API.Validators;

public class AudienceRequestDtoValidator : AbstractValidator<AudienceRequestDto>
{
    public AudienceRequestDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required.");
    }
}
