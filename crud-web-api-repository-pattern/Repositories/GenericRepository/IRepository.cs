using crud_web_api_repository_pattern.Repositories.UnitOfWorks;
using System.Linq.Expressions;

namespace crud_web_api_repository_pattern.Repositories.GenericRepository;

public interface IRepository<T> : IUnitOfWork where T : class
{
    Task AddAsync(T entity);
    Task<T> GetByIdAsync(int id);
    Task<T> GetAsync(Expression<Func<T, bool>> where);
}
