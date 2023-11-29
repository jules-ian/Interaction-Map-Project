using FluentValidation;
using InteractiveMapProject.API.Validators.FieldOfIntervetion;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;

namespace InteractiveMapProject.API.Validators;

public class ProfessionalFilterRequestValidator : AbstractValidator<ProfessionalFilterRequest>
{
    public ProfessionalFilterRequestValidator()
    {
        RuleFor(x => x.PostalCode)
            .NotNull().WithMessage("Postal code is required.");
        RuleFor(x => x.Audiences)
            .NotNull().WithMessage("Audiences are required.");
        RuleFor(x => x.PlacesOfIntervention)
            .NotNull().WithMessage("Places of intervention are required.");
        RuleFor(x => x.Missions)
            .NotNull().WithMessage("Missions are required.");
    }
}
