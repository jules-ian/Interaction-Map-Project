using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Filtering;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Contracts.UoW;
using InteractiveMapProject.Data.Db.Context;
using InteractiveMapProject.Data.Db.Repositories;

namespace InteractiveMapProject.Data.Db.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly IProfessionalRepository _professionals;
    private readonly IPendingProfessionalRepository _pendingProfessionals;
    private readonly IRepository<Audience> _audiences;
    private readonly IRepository<Mission> _missions;
    private readonly IRepository<PlaceOfIntervention> _placesOfIntervention;
    private readonly IRepository<ProfessionalAudience> _professionalAudiences;
    private readonly IRepository<ProfessionalPlaceOfIntervention> _professionalPlacesOfIntervention;
    private readonly IRepository<ProfessionalMission> _professionalMissions;
    private readonly IRepository<PendingProfessionalAudience> _pendingProfessionalAudiences;
    private readonly IRepository<PendingProfessionalPlaceOfIntervention> _pendingProfessionalPlacesOfIntervention;
    private readonly IRepository<PendingProfessionalMission> _pendingProfessionalMissions;
    private readonly IRepository<ValidationStatus> _validationStatuses;

    private readonly IFilterFactory<Professional, ProfessionalFilterRequest> _filterFactory;

    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext context,
        IFilterFactory<Professional, ProfessionalFilterRequest> filterFactory)
    {
        _dbContext = context;
        _filterFactory = filterFactory;
    }

    public IProfessionalRepository Professionals
        => _professionals ?? new ProfessionalRepository(_dbContext, _filterFactory);

    public IPendingProfessionalRepository PendingProfessionals
        => _pendingProfessionals ?? new PendingProfessionalRepository(_dbContext);

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

    public IRepository<PendingProfessionalAudience> PendingProfessionalAudiences
        => _pendingProfessionalAudiences ?? new Repository<PendingProfessionalAudience>(_dbContext);

    public IRepository<PendingProfessionalPlaceOfIntervention> PendingProfessionalPlacesOfIntervention
        => _pendingProfessionalPlacesOfIntervention ??
           new Repository<PendingProfessionalPlaceOfIntervention>(_dbContext);

    public IRepository<PendingProfessionalMission> PendingProfessionalMissions
        => _pendingProfessionalMissions ?? new Repository<PendingProfessionalMission>(_dbContext);

    public IRepository<ValidationStatus> ValidationStatuses
        => _validationStatuses ?? new Repository<ValidationStatus>(_dbContext);

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
