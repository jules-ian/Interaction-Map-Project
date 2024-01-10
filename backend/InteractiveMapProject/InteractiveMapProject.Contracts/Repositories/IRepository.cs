using System.Linq.Expressions;

namespace InteractiveMapProject.Contracts.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity?> GetAsync(Guid id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> e);
}
