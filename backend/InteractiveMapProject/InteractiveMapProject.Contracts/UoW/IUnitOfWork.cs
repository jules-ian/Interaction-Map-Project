using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Repositories;

namespace InteractiveMapProject.Contracts.UoW;

public interface IUnitOfWork
{
    IProfessionalRepository Professionals { get; }
    IPendingProfessionalRepository PendingProfessionals { get; }
    IRepository<Audience> Audiences { get; }
    IRepository<PlaceOfIntervention> PlacesOfIntervention { get; }
    IRepository<Mission> Missions { get; }
    IRepository<ProfessionalAudience> ProfessionalAudiences { get; }
    IRepository<ProfessionalPlaceOfIntervention> ProfessionalPlacesOfIntervention { get; }
    IRepository<ProfessionalMission> ProfessionalMissions { get; }
    IRepository<PendingProfessionalAudience> PendingProfessionalAudiences { get; }
    IRepository<PendingProfessionalPlaceOfIntervention> PendingProfessionalPlacesOfIntervention { get; }
    IRepository<PendingProfessionalMission> PendingProfessionalMissions { get; }
    IRepository<ValidationStatus> ValidationStatuses { get; }
    Task SaveChangesAsync();
}
