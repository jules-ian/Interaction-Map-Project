using System.Linq.Expressions;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public class ProfessionalFilterFactory : IFilterFactory<Professional, ProfessionalFilterRequest>
{
    public Expression<Func<Professional, bool>>[] BuildFilters(ProfessionalFilterRequest? request = null)
    {
        List<Expression<Func<Professional, bool>>> dbFilters = new();

        if (request?.Audiences?.Any() == true)
        {
            dbFilters.Add(ProfessionalFilterSpecification.FilterByAudience(request.Audiences));
        }

        if (request?.PlacesOfIntervention?.Any() == true)
        {
            dbFilters.Add(ProfessionalFilterSpecification.FilterByPlaceOfIntervention(request.PlacesOfIntervention));
        }

        if (request?.Missions?.Any() == true)
        {
            dbFilters.Add(ProfessionalFilterSpecification.FilterByMission(request.Missions));
        }

        if (request?.MapSquare != null)
        {
            dbFilters.Add(ProfessionalFilterSpecification.FilterByMapSquare(request.MapSquare));
        }

        return dbFilters.ToArray();
    }
}
