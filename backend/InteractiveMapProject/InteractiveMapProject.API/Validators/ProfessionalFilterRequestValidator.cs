using FluentValidation;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;

namespace InteractiveMapProject.API.Validators;

public class ProfessionalFilterRequestValidator : AbstractValidator<ProfessionalFilterRequest>
{
    public ProfessionalFilterRequestValidator()
    {
        RuleFor(x => x.MapSquare)
            .SetValidator(new MapSquareValidator());
    }
}
