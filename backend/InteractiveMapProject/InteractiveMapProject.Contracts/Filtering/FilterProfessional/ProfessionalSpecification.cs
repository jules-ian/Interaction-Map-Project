using System.Linq.Expressions;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public static class ProfessionalSpecification
{
    public static Expression<Func<Professional, bool>> FilterByPostalCode(string postalCode) =>
        x => postalCode.Equals(x.Address.PostalCode);
    public static Expression<Func<Professional, bool>> FilterByAudience(IEnumerable<string> audiences) =>
        x => audiences.Intersect(x.Audiences.ToList().Select(y => y.Audience.Name)).Count() > 0;
    public static Expression<Func<Professional, bool>> FilterByPlaceOfIntervetion(IEnumerable<string> placesOfIntervetion) =>
        x => placesOfIntervetion.Intersect(x.PlacesOfIntervention.ToList().Select(y => y.PlaceOfIntervention.Name)).Count() > 0;
    public static Expression<Func<Professional, bool>> FilterByMission(IEnumerable<string> missions) =>
        x => missions.Intersect(x.Missions.ToList().Select(y => y.Mission.Name)).Count() > 0;
}
