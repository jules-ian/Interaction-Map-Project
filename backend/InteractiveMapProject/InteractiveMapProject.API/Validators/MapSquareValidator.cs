using FluentValidation;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;

namespace InteractiveMapProject.API.Validators;

public class MapSquareValidator : AbstractValidator<MapSquare>
{
    public MapSquareValidator()
    {
        RuleFor(x => x.NorthEastLatitude)
            .NotNull().WithMessage("North-West Latitude is required.");
        RuleFor(x => x.NorthEastLongitude)
            .NotNull().WithMessage("North-West Longitude is required.");
        RuleFor(x => x.SouthWestLatitude)
            .NotNull().WithMessage("South-East Latitude is required.");
        RuleFor(x => x.SouthWestLongitude)
            .NotNull().WithMessage("South-East Longitude is required.");
    }
}
