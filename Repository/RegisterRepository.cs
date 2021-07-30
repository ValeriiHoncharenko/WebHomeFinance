using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHomeFinance.Models; 
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using WebHomeFinance.DTO;

namespace WebHomeFinance.Repository
{  
    public class RegisterRepository: IRepository<RegisterTransaction>
    {
        private readonly FinanceDBContext _context;
        public RegisterRepository(FinanceDBContext context)
        {
            this._context = context;
        }
        public IEnumerable<RegisterTransaction> GetAll()
        {
            return _context.RegisterTransactions.AsEnumerable();
        }
        public async Task<RegisterTransaction> AddAsync(RegisterTransaction registerTransaction)
        {
            _context.RegisterTransactions.Add(registerTransaction);
            await _context.SaveChangesAsync();
            return registerTransaction;
        }
        public async Task<RegisterTransaction> DeleteAsync(int id)
        {
            RegisterTransaction nameFinded = _context.RegisterTransactions.Find(id);
            _context.RegisterTransactions.Remove(nameFinded);
            await _context.SaveChangesAsync();
            return nameFinded;
        }
        public IEnumerable<RegisterTransaction> SelectDateAsync(DateTime date1, DateTime date2)
        {    
           throw new NotImplementedException();                           
        }
        public async Task<RegisterTransaction> UpdateAsync(RegisterTransaction registerTransaction)
        {
            _context.Update(registerTransaction);
            await _context.SaveChangesAsync();
            return registerTransaction;
        }

        public async Task<RegisterTransaction> FindByIdAsync(int id)
        {
            return await _context.RegisterTransactions.FirstOrDefaultAsync(registerTransaction => registerTransaction.Id == id);
        }
       
    }    
}
