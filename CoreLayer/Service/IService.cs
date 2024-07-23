﻿using System.Linq.Expressions;

namespace CoreLayer.Service
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    }
}
