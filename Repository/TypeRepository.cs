using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHomeFinance.Models;

namespace WebHomeFinance.Repository
{
    public class TypeRepository : IRepository<TypeTransaction>
    {
        private readonly FinanceDBContext _context;

        public TypeRepository(FinanceDBContext context)
        {
            this._context = context;
        }
        public IEnumerable<TypeTransaction> GetAll()
        {
            return _context.TypeTransactions.AsEnumerable();
        }

        public async Task<TypeTransaction> AddAsync(TypeTransaction typeTransaction)
        {
            _context.TypeTransactions.Add(typeTransaction);
            await _context.SaveChangesAsync();
            return typeTransaction;
        }

        public Task<TypeTransaction> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TypeTransaction> UpdateAsync(TypeTransaction entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TypeTransaction> SelectDateAsync(DateTime date1, DateTime date2)
        {
            throw new NotImplementedException();
        }

        public Task<TypeTransaction> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
