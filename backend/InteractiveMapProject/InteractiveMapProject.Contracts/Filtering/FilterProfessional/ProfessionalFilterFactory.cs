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
            dbFilters.Add(ProfessionalSpecification.FilterByAudience(request.Audiences));
        }

        if (request?.PlacesOfIntervention?.Any() == true)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByPlaceOfIntervention(request.PlacesOfIntervention));
        }

        if (request?.Missions?.Any() == true)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByMission(request.Missions));
        }

        if (request?.MapSquare != null)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByMapSquare(request.MapSquare));
        }

        return dbFilters.ToArray();
    }
}
