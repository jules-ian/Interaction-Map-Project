using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Contracts.UoW;
using InteractiveMapProject.Data.Db.Context;
using InteractiveMapProject.Data.Db.Repositories;

namespace InteractiveMapProject.Data.Db.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly IProfessionalRepository _professionals;

    private readonly ProfessionalFilterFactory _filterFactory;

    private readonly ApplicationDbContext _dbContext;
    public UnitOfWork(ApplicationDbContext context)
    {
        _dbContext = context;
    }

    public IProfessionalRepository Professionals
        => _professionals ?? new ProfessionalRepository(_dbContext, _filterFactory);

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
