using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHomeFinance.Repository
{
    public interface IRepository<TEntity> where TEntity: class
    {
        public IEnumerable<TEntity> GetAll();
        public Task<TEntity> AddAsync(TEntity entity);
        public Task<TEntity> DeleteAsync(int id);
        public Task<TEntity> UpdateAsync(TEntity entity);
        public IEnumerable<TEntity> SelectDateAsync(DateTime date1, DateTime date2);
        public Task<TEntity> FindByIdAsync(int id);           
    }
}
