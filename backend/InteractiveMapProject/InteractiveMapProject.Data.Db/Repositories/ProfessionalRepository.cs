using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Data.Db.Context;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Repositories;

public class ProfessionalRepository : Repository<Professional>, IProfessionalRepository
{
    private readonly DbSet<Professional> _professionals;

    public ProfessionalRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _professionals = dbContext.Set<Professional>();
    }

    public Task<List<Professional>> GetAllAsync(ProfessionalFilterRequest filterRequest)
    {
        throw new NotImplementedException();
    }
}
