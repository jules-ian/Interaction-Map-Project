using FluentValidation;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;

namespace InteractiveMapProject.API.Validators;

public class MapSquareValidator : AbstractValidator<MapSquare>
{
    public MapSquareValidator()
    {
        RuleFor(x => x.NorthWestLatitude)
            .NotNull().WithMessage("North-West Latitude is required.");
        RuleFor(x => x.NorthWestLongitude)
            .NotNull().WithMessage("North-West Longitude is required.");
        RuleFor(x => x.SouthEastLatitude)
            .NotNull().WithMessage("South-East Latitude is required.");
        RuleFor(x => x.SouthEastLongitude)
            .NotNull().WithMessage("South-East Longitude is required.");
    }
}
