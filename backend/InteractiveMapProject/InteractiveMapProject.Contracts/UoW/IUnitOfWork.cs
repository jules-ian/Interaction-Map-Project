using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Repsitories;

namespace InteractiveMapProject.Contracts.UoW;

public interface IUnitOfWork
{
    IRepository<Professional> Professionals { get; }
    IRepository<Audience> Audiences { get; }
    IRepository<Mission> Missions { get; }
    IRepository<PlaceOfIntervention> PlacesOfIntervention { get; }
    Task SaveChangesAsync();
}
