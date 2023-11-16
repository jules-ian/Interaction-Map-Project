using FluentValidation;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.API.Validators;

public class MissionDtoValidator : AbstractValidator<MissionDto>
{
    public MissionDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required.");
    }
}
