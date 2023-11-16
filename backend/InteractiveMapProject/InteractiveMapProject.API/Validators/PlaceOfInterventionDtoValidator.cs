using FluentValidation;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;

namespace InteractiveMapProject.API.Validators;

public class PlaceOfInterventionDtoValidator : AbstractValidator<PlaceOfInterventionDto>
{
    public PlaceOfInterventionDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required.");
    }
}
