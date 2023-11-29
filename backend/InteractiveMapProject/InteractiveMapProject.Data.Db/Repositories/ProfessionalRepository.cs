using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Data.Db.Context;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Repositories;

public class ProfessionalRepository : Repository<Professional>, IProfessionalRepository
{
    private readonly DbSet<Professional> _professionals;
    private readonly ProfessionalFilterFactory _filterFactory;

    public ProfessionalRepository(ApplicationDbContext dbContext, ProfessionalFilterFactory filterFactory) : base(dbContext)
    {
        _professionals = dbContext.Set<Professional>();
        _filterFactory = filterFactory;
    }

    public async Task<List<Professional>> GetAllAsync(ProfessionalFilterRequest filterRequest)
    {
        IQueryable<Professional> query = _professionals.AsQueryable();

        var filters = _filterFactory.BuildFilters(filterRequest);

        if (filters?.Any() == true)
        {
            query = filters.Aggregate(query, (current, item) => current.Where(item));
        }
        return await _professionals.ToListAsync();
    }
}
