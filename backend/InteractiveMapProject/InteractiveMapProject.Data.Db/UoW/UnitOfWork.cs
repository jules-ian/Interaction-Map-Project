using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Repsitories;
using InteractiveMapProject.Contracts.UoW;
using InteractiveMapProject.Data.Db.Context;
using InteractiveMapProject.Data.Db.Repositories;

namespace InteractiveMapProject.Data.Db.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly IRepository<Professional> _professionals;

    private readonly ApplicationDbContext _dbContext;
    public UnitOfWork(ApplicationDbContext context)
    {
        _dbContext = context;
    }

    public IRepository<Professional> Professionals
        => _professionals ?? new Repository<Professional>(_dbContext);

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
