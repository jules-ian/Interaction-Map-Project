using FluentValidation;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.API.Validators.FieldOfIntervetion;

public class PlaceOfInterventionRequestDtoValidator : AbstractValidator<PlaceOfInterventionRequestDto>
{
    public PlaceOfInterventionRequestDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required.");
    }
}
