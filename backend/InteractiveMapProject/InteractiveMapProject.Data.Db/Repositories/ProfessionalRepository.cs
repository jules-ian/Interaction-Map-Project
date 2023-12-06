using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Filtering;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Data.Db.Context;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Repositories;

public class ProfessionalRepository : Repository<Professional>, IProfessionalRepository
{
    private readonly DbSet<Professional> _professionals;
    private readonly IFilterFactory<Professional, ProfessionalFilterRequest> _filterFactory;

    public ProfessionalRepository(ApplicationDbContext dbContext,
        IFilterFactory<Professional, ProfessionalFilterRequest> filterFactory) : base(dbContext)
    {
        _professionals = dbContext.Set<Professional>();
        _filterFactory = filterFactory;
    }

    public new async Task<List<Professional>> GetAllAsync()
    {
        return await _professionals
            .Include(p => p.Audiences).ThenInclude(pa => pa.Audience)
            .Include(p => p.Missions).ThenInclude(pm => pm.Mission)
            .Include(p => p.PlacesOfIntervention).ThenInclude(pp => pp.PlaceOfIntervention)
            .ToListAsync();
    }

    public async Task<List<Professional>> GetAllAsync(ProfessionalFilterRequest filterRequest)
    {
        IQueryable<Professional> query = _professionals.AsQueryable();

        var filters = _filterFactory.BuildFilters(filterRequest);

        if (filters?.Any() == true)
        {
            query = filters.Aggregate(query, (current, item) => current.Where(item));
        }

        return await query.ToListAsync();
    }

    public new async Task<Professional?> GetAsync(Guid id)
    {
        return await _professionals
            .Include(p => p.Audiences).ThenInclude(pa => pa.Audience)
            .Include(p => p.Missions).ThenInclude(pm => pm.Mission)
            .Include(p => p.PlacesOfIntervention).ThenInclude(pp => pp.PlaceOfIntervention)
            .SingleOrDefaultAsync(p => p.Id == id);
    }
}
