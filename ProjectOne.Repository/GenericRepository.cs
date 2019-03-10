using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectOne.Contracts.Repository;

namespace ProjectOne.Repository{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _repositoryContext;
        public GenericRepository(DbContext context) =>_repositoryContext = context;
        public async Task<T> CreateAsync(T entity)
        {
            var result = _repositoryContext.Set<T>().Add(entity).Entity;
            await _repositoryContext.SaveChangesAsync();
            return result;
        }
        public async Task CreateAsync(IEnumerable<T> entities)
        {
            _repositoryContext.Set<T>().AddRange(entities);
            await _repositoryContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(T entity)
        {
            _repositoryContext.Set<T>().Remove(entity);
            await _repositoryContext.SaveChangesAsync();
        }
        public async Task<T> FindAsync(string id) => await _repositoryContext.Set<T>().FindAsync(id);
        public async Task<T> FindAsync(long id) => await _repositoryContext.Set<T>().FindAsync(id);
        public async Task<T> FindAsync(int id) => await _repositoryContext.Set<T>().FindAsync(id);
        public async Task<T> FindAsync(Expression<Func<T, bool>> predicate) => await _repositoryContext.Set<T>().FindAsync(predicate);
        public async Task<IEnumerable<T>> GetAllAsync() => await _repositoryContext.Set<T>().ToListAsync();
        public async Task<T> UpdateAsync(T entity)
        {
            var result = _repositoryContext.Set<T>().Update(entity).Entity;
            await _repositoryContext.SaveChangesAsync();
            return result;
        }
        public IEnumerable<T> Where(Expression<Func<T, bool>> predicate) => _repositoryContext.Set<T>().Where(predicate);
    }
}