using System.Linq.Expressions;

namespace InteractiveMapProject.Contracts.Filtering;

public interface IFilterFactory<T, TFilterRequest>
{
    Expression<Func<T, bool>>[] BuildFilters(TFilterRequest? request);
}
