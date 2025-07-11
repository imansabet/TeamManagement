using System.Linq.Expressions;

namespace TeamManagement.Domain.SeedWork;

public interface IGenericRepository<T> where T : Entity
{
    IUnitOfWork UnitOfWork { get; } 
    Task<bool> AnyAsync(Expression<Func<T,bool>> entity);
    Task<T> AddAsync(T entity);
    Task<T> GetByIdAsync(int id , params string[] includes);
    Task<T> Get(Expression<Func<T,bool>> predicate , params string[] includes);
    Task<IReadOnlyList<T>> GetAll(Expression<Func<T, bool>> predicate = null, params string[] includes);
    Task UpdateAsync(T entity);
}
