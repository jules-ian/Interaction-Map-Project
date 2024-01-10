using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;

namespace InteractiveMapProject.Contracts.Repositories;

public interface IProfessionalRepository : IRepository<Professional>
{
    Task<List<Professional>> GetAllAsync(ProfessionalFilterRequest filterRequest);
}
