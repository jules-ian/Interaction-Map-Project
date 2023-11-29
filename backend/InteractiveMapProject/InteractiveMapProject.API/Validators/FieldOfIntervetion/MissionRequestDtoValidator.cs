using FluentValidation;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.API.Validators.FieldOfIntervetion;

public class MissionRequestDtoValidator : AbstractValidator<MissionRequestDto>
{
    public MissionRequestDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required.");
    }
}
