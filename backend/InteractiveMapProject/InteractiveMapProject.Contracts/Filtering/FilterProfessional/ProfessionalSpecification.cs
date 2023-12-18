using System.Linq.Expressions;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public static class ProfessionalSpecification
{
    public static Expression<Func<Professional, bool>> FilterByAudience(IEnumerable<Guid> audiences) =>
        x => x.Audiences.Any(professional => audiences.Contains(professional.Audience.Id));

    public static Expression<Func<Professional, bool>>
        FilterByPlaceOfIntervention(IEnumerable<Guid> placesOfIntervention) =>
        x => x.PlacesOfIntervention.Any(professional =>
            placesOfIntervention.Contains(professional.PlaceOfIntervention.Id));

    public static Expression<Func<Professional, bool>> FilterByMission(IEnumerable<Guid> missions) =>
        x => x.Missions.Any(professional => missions.Contains(professional.Mission.Id));

    public static Expression<Func<Professional, bool>>
        FilterByMapSquare(MapSquare mapSquare) =>
        x =>
            mapSquare.NorthWestLatitude >= x.Geolocation.Latitude &&
            mapSquare.SouthEastLatitude <= x.Geolocation.Latitude &&
            mapSquare.NorthWestLongitude <= x.Geolocation.Longitude &&
            mapSquare.SouthEastLongitude >= x.Geolocation.Longitude;
}
