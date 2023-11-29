using InteractiveMapProject.Contracts.Repositories;

namespace InteractiveMapProject.Contracts.UoW;

public interface IUnitOfWork
{
    IProfessionalRepository Professionals { get; }
    Task SaveChangesAsync();
}
