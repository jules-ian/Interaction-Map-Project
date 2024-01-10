using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

namespace InteractiveMapProject.Contracts.UoW;

public interface IUnitOfWork
{
    IProfessionalRepository Professionals { get; }
    IRepository<Audience> Audiences { get; }
    IRepository<PlaceOfIntervention> PlacesOfIntervention { get; }
    IRepository<Mission> Missions { get; }
    IRepository<ProfessionalAudience> ProfessionalAudiences { get; }
    IRepository<ProfessionalPlaceOfIntervention> ProfessionalPlacesOfIntervention { get; }
    IRepository<ProfessionalMission> ProfessionalMissions { get; }
    Task SaveChangesAsync();
}
