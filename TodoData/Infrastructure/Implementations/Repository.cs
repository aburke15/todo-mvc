using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoData
{
    public class Repository<T> : IRepositoy<T> where T : class
    {
        private readonly TodoContext _context;

        public Repository(TodoContext context)
            => _context = context;

        public virtual void Add(T entity) 
            => _context.Set<T>().Add(entity);

        public async Task AddAsync(T entity) 
            => await _context.Set<T>().AddAsync(entity);

        public void AddRange(IEnumerable<T> entities) 
            => _context.Set<T>().AddRange(entities);

        public async Task AddRangeAsync(IEnumerable<T> entities)
            => await _context.Set<T>().AddRangeAsync(entities);

        public virtual IEnumerable<T> GetAll() 
            => _context.Set<T>();

        public virtual async Task<T> GetByIdAsync(Guid id) 
            => await _context.Set<T>().FindAsync(id);

        public async Task<T> GetByIdAsync(int id) 
            => await _context.Set<T>().FindAsync(id);

        public void Remove(T entity) 
            => _context.Set<T>().Remove(entity);

        public void RemoveRange(IEnumerable<T> entities) 
            => _context.Set<T>().RemoveRange(entities);

        public void Update(T entity) 
            => _context.Set<T>().Update(entity);

        public void UpdateRange(IEnumerable<T> entities) 
            => _context.Set<T>().UpdateRange(entities);
    }
}