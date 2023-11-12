using FluentValidation;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.API.Validators;

public class FieldOfInterventionValidator : AbstractValidator<FieldOfIntervention>
{
    public FieldOfInterventionValidator()
    {
        RuleFor(x => x.Audience)
            .NotNull().WithMessage("Audience is required.");
        RuleFor(x => x.SectorOfIntervetion)
            .NotNull().WithMessage("Sector of intervetion is required.");
        RuleFor(x => x.PlaceOfIntervention)
            .NotNull().WithMessage("Place of intervention is required.");
    }
}
