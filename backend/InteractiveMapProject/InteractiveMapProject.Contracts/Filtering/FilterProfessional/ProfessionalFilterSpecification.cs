using System.Linq.Expressions;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public static class ProfessionalFilterSpecification
{
    public static Expression<Func<Professional, bool>> FilterByAudience(IEnumerable<Guid> audiences) =>
        x => x.Audiences.Any(professional => audiences.Contains(professional.Audience.Id));

    public static Expression<Func<Professional, bool>> FilterByPlaceOfIntervention(
        IEnumerable<Guid> placesOfIntervention) =>
        x => x.PlacesOfIntervention.Any(professional =>
            placesOfIntervention.Contains(professional.PlaceOfIntervention.Id));

    public static Expression<Func<Professional, bool>> FilterByMission(IEnumerable<Guid> missions) =>
        x => x.Missions.Any(professional => missions.Contains(professional.Mission.Id));

    public static Expression<Func<Professional, bool>>
        FilterByMapSquare(MapSquare mapSquare) =>
        x =>
            mapSquare.NorthEastLatitude >= x.Geolocation.Latitude &&
            mapSquare.NorthEastLongitude >= x.Geolocation.Longitude &&
            mapSquare.SouthWestLatitude <= x.Geolocation.Latitude &&
            mapSquare.SouthWestLongitude <= x.Geolocation.Longitude;
}
