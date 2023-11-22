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

        if (request?.AudienceIds.Any() == true)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByAudience(request.AudienceIds));
        }

        if (request?.PlaceOfInterventionIds.Any() == true)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByAudience(request.PlaceOfInterventionIds));
        }

        if (request?.MissionIds.Any() == true)
        {
            dbFilters.Add(ProfessionalSpecification.FilterByAudience(request.MissionIds));
        }

        return dbFilters.ToArray();
    }
}
