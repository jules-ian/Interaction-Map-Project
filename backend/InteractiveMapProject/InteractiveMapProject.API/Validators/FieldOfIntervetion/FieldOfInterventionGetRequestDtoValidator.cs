using FluentValidation;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.API.Validators.FieldOfIntervetion;

public class FieldOfInterventionGetRequestDtoValidator : AbstractValidator<FieldOfInterventionGetRequestDto>
{
    public FieldOfInterventionGetRequestDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotNull().WithMessage("Id is required.");
    }
}
