using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoData
{
    public interface IRepositoy<T> where T : class
    {
        void Add(T entity);

        Task AddAsync(T entity);

        void AddRange(IEnumerable<T> entities);

        Task AddRangeAsync(IEnumerable<T> entities);

        Task<T> GetByIdAsync(Guid id);

        Task<T> GetByIdAsync(int id);

        IEnumerable<T> GetAll();

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entities);
    }
}