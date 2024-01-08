using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Repositories;

public interface IPendingProfessionalRepository : IRepository<PendingProfessional>
{
    new Task<PendingProfessional?> GetAsync(Guid id);
    new Task<List<PendingProfessional>> GetAllAsync();
}
