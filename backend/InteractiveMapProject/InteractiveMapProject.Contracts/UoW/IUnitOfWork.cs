using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

namespace InteractiveMapProject.Contracts.UoW;

public interface IUnitOfWork
{

    IProfessionalRepository Professionals { get; }
    IRepository<Audience> Audiences { get; }
    IRepository<Mission> Missions { get; }
    IRepository<PlaceOfIntervention> PlacesOfIntervention { get; }
    Task SaveChangesAsync();
}
