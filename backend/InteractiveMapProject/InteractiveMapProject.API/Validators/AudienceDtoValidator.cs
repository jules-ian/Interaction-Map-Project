using FluentValidation;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.API.Validators;

public class AudienceDtoValidator : AbstractValidator<AudienceDto>
{
    public AudienceDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required.");
    }
}
