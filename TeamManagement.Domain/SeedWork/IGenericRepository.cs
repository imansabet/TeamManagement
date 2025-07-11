using System.Linq.Expressions;

namespace TeamManagement.Domain.SeedWork;

public interface IGenericRepository<T> where T : Entity
{
    Task<T> AddAsync(T entity);
    Task GetByIdAsync(int id);
    Task Get(Expression<Func<T,bool>> predicate);
    Task<IReadOnlyList<T>> GetAll();
    Task UpdateAsync(T entity);
}
