using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectOne.Contracts.Repository
{
    public interface IRepository<T>
    {
        Task<T> FindAsync(string id);
        Task<T> FindAsync(long id);
        Task<T> FindAsync(int id);
        Task<T> FindAsync(Expression<Func<T,bool>> predicate);
        IEnumerable<T> Where(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(T entity);
        Task CreateAsync(IEnumerable<T> entities);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}