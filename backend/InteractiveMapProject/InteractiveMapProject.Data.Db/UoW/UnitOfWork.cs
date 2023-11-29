using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Repsitories;
using InteractiveMapProject.Contracts.UoW;
using InteractiveMapProject.Data.Db.Context;
using InteractiveMapProject.Data.Db.Repositories;

namespace InteractiveMapProject.Data.Db.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly IRepository<Professional> _professionals;
    private readonly IRepository<Audience> _audiences;
    private readonly IRepository<Mission> _missions;
    private readonly IRepository<PlaceOfIntervention> _placesOfIntervention;

    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext context)
    {
        _dbContext = context;
    }

    public IRepository<Professional> Professionals
        => _professionals ?? new Repository<Professional>(_dbContext);

    public IRepository<Audience> Audiences
        => _audiences ?? new Repository<Audience>(_dbContext);

    public IRepository<Mission> Missions
        => _missions ?? new Repository<Mission>(_dbContext);

    public IRepository<PlaceOfIntervention> PlacesOfIntervention
        => _placesOfIntervention ?? new Repository<PlaceOfIntervention>(_dbContext);

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
