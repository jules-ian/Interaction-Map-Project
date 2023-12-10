using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Filtering;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.UoW;
using InteractiveMapProject.Data.Db.Context;
using InteractiveMapProject.Data.Db.Repositories;

namespace InteractiveMapProject.Data.Db.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly IProfessionalRepository _professionals;
    private readonly IRepository<Audience> _audiences;
    private readonly IRepository<Mission> _missions;
    private readonly IRepository<PlaceOfIntervention> _placesOfIntervention;
    private readonly IRepository<ProfessionalAudience> _professionalAudiences;
    private readonly IRepository<ProfessionalPlaceOfIntervention> _professionalPlacesOfIntervention;
    private readonly IRepository<ProfessionalMission> _professionalMissions;

    private readonly IFilterFactory<Professional, ProfessionalFilterRequest> _filterFactory;

    private readonly ApplicationDbContext _dbContext;
    public UnitOfWork(ApplicationDbContext context, IFilterFactory<Professional, ProfessionalFilterRequest> filterFactory)
    {
        _dbContext = context;
        _filterFactory = filterFactory;
    }

    public IProfessionalRepository Professionals
        => _professionals ?? new ProfessionalRepository(_dbContext, _filterFactory);

    public IRepository<Audience> Audiences
        => _audiences ?? new Repository<Audience>(_dbContext);

    public IRepository<Mission> Missions
        => _missions ?? new Repository<Mission>(_dbContext);

    public IRepository<PlaceOfIntervention> PlacesOfIntervention
        => _placesOfIntervention ?? new Repository<PlaceOfIntervention>(_dbContext);

    public IRepository<ProfessionalAudience> ProfessionalAudiences
        => _professionalAudiences ?? new Repository<ProfessionalAudience>(_dbContext);

    public IRepository<ProfessionalPlaceOfIntervention> ProfessionalPlacesOfIntervention
        => _professionalPlacesOfIntervention ?? new Repository<ProfessionalPlaceOfIntervention>(_dbContext);

    public IRepository<ProfessionalMission> ProfessionalMissions
        => _professionalMissions ?? new Repository<ProfessionalMission>(_dbContext);

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
