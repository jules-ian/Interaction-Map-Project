using System.Linq.Expressions;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Filtering;

public static class ProfessionalSpecification
{
    public static Expression<Func<Professional, bool>> FilterByPostalCode(string postalCode) =>
        x => postalCode.Equals(x.Address.PostalCode);
    public static Expression<Func<Professional, bool>> FilterByAudience(IEnumerable<Guid> audienceIds) =>
        x => audienceIds.Intersect(x.Audiences.ToList().Select(y => y.Audience.Id)).Count() > 0;
    public static Expression<Func<Professional, bool>> FilterByPlaceOfIntervetion(IEnumerable<Guid> placeOfIntervetionIds) =>
        x => placeOfIntervetionIds.Intersect(x.PlacesOfIntervention.ToList().Select(y => y.PlaceOfIntervention.Id)).Count() > 0;
    public static Expression<Func<Professional, bool>> FilterByMission(IEnumerable<Guid> missionIds) =>
        x => missionIds.Intersect(x.Missions.ToList().Select(y => y.Mission.Id)).Count() > 0;
}
