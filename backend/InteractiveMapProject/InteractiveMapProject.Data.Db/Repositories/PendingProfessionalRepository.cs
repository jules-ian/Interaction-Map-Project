using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Data.Db.Context;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Repositories;

public class PendingProfessionalRepository : Repository<PendingProfessional>, IPendingProfessionalRepository
{
    private readonly DbSet<PendingProfessional> _pendingProfessionals;

    public PendingProfessionalRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _pendingProfessionals = dbContext.Set<PendingProfessional>();
    }

    public new async Task<PendingProfessional?> GetAsync(Guid id)
    {
        return await _pendingProfessionals
            .Include(p => p.Audiences).ThenInclude(pa => pa.Audience)
            .Include(p => p.Missions).ThenInclude(pm => pm.Mission)
            .Include(p => p.PlacesOfIntervention).ThenInclude(pp => pp.PlaceOfIntervention)
            .Include(p => p.ValidationStatus)
            .Include(p => p.Professional)
            .SingleOrDefaultAsync(p => p.Id == id);
    }

    public new async Task<List<PendingProfessional>> GetAllAsync()
    {
        return await _pendingProfessionals
            .Include(p => p.Audiences).ThenInclude(pa => pa.Audience)
            .Include(p => p.Missions).ThenInclude(pm => pm.Mission)
            .Include(p => p.PlacesOfIntervention).ThenInclude(pp => pp.PlaceOfIntervention)
            .Include(p => p.ValidationStatus)
            .Include(p => p.Professional)
            .ToListAsync();
    }
}
