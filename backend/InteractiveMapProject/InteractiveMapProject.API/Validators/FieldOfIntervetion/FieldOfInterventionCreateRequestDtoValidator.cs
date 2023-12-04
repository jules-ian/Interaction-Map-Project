using FluentValidation;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.API.Validators.FieldOfIntervetion;

public class FieldOfInterventionCreateRequestDtoValidator : AbstractValidator<FieldOfInterventionCreateRequestDto>
{
    public FieldOfInterventionCreateRequestDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required.");
    }
}
