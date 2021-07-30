using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHomeFinance.Models;


namespace WebHomeFinance.Repository
{
    public class NameRepository : IRepository<NameTransaction>
    {
        private readonly FinanceDBContext _context;      

        public NameRepository(FinanceDBContext context)
        {
             this._context = context;            
        }
        public IEnumerable<NameTransaction> GetAll()
        {
            return _context.NameTransactions.AsEnumerable();
        }

        public async Task<NameTransaction> AddAsync(NameTransaction nameTransaction)
        {
            _context.NameTransactions.Add(nameTransaction);
            await _context.SaveChangesAsync();
            return nameTransaction;
        }

        public async Task<NameTransaction> DeleteAsync(int id)
        {
            NameTransaction nameFinded = _context.NameTransactions.Find(id);
            _context.NameTransactions.Remove(nameFinded);           
            await _context.SaveChangesAsync();
            return nameFinded;
        }

        public async Task<NameTransaction> FindByIdAsync(int id)
        {
            return await _context.NameTransactions.FirstOrDefaultAsync(nameTransaction => nameTransaction.Id == id);
        }      

        public IEnumerable<NameTransaction> SelectDateAsync(DateTime date1, DateTime date2)
        {
            throw new NotImplementedException();
        }

        public async Task<NameTransaction> UpdateAsync(NameTransaction nameTransaction)
        {
            _context.Update(nameTransaction);           
            await _context.SaveChangesAsync();
            return nameTransaction;
        }       
    }
}
