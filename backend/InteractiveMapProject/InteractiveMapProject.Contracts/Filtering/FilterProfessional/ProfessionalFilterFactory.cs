using System.Linq.Expressions;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Filtering.FilterProfessional;

public class ProfessionalFilterFactory : IFilterFactory<Professional, ProfessionalFilterRequest>
{
    public Expression<Func<Professional, bool>>[] BuildFilters(ProfessionalFilterRequest? request = null)
    {
        List<Expression<Func<Professional, bool>>> dbFilters = new();

        if (request?.PostalCode != null)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByPostalCode(request.PostalCode));
        }

        if (request?.Audiences.Any() == true)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByAudience(request.Audiences));
        }

        if (request?.PlacesOfIntervention.Any() == true)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByAudience(request.PlacesOfIntervention));
        }

        if (request?.Missions.Any() == true)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByAudience(request.Missions));
        }

        return dbFilters.ToArray();
    }
}
