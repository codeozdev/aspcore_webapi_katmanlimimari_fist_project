using System.Linq.Expressions;

namespace CoreLayer.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    }
}
