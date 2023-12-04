using System.Linq.Expressions;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public static class ProfessionalSpecification
{
    public static Expression<Func<Professional, bool>> FilterByPostalCode(string postalCode) =>
        x => postalCode.Equals(x.Address.PostalCode);
    public static Expression<Func<Professional, bool>> FilterByAudience(IEnumerable<Guid> audiences) =>
        x => x.Audiences.Any(professional => audiences.Contains(professional.Audience.Id));
    public static Expression<Func<Professional, bool>> FilterByPlaceOfIntervetion(IEnumerable<Guid> placesOfIntervetion) =>
        x => x.PlacesOfIntervention.Any(professional => placesOfIntervetion.Contains(professional.PlaceOfIntervention.Id));
    public static Expression<Func<Professional, bool>> FilterByMission(IEnumerable<Guid> missions) =>
        x => x.Missions.Any(professional => missions.Contains(professional.Mission.Id));
}
