using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHomeFinance.DTO;
using WebHomeFinance.Models;

namespace WebHomeFinance.Repository
{
    public class ReportRepository : IRepository<ModelReport>
    {
        private readonly FinanceDBContext _context;       
        public ReportRepository(FinanceDBContext context)
        {
            this._context = context;
        }
        public Task<ModelReport> AddAsync(ModelReport entity)
        {
            throw new NotImplementedException();
        }
        public Task<ModelReport> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<ModelReport> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ModelReport> GetAll()
        {
            throw new NotImplementedException();            
        }
        public IEnumerable<ModelReport> SelectDateAsync(DateTime date1, DateTime date2)
        {
            decimal sumExp = 0;
            decimal sumInc = 0;
            
            var regInc =( from rt in _context.RegisterTransactions
                      join nt in _context.NameTransactions 
                      on rt.NameTransactionId equals nt.Id
                      join tt in _context.TypeTransactions
                      on nt.TypeTransaction equals tt.Id
                      where rt.DateTransaction >= date1 & rt.DateTransaction <= date2 & nt.TypeTransaction == 1
                      select  new 
                      {
                          rt.Id,
                          rt.DateTransaction,
                          nt.Name,
                          tt.TypeTrans,
                          rt.Amount,                          
                      }).AsEnumerable()
                          .Select(an => new ModelReport
                          {
                              Id = an.Id,
                              DateTransaction = an.DateTransaction,
                              Name = an.Name,
                              TypeTransaction = an.TypeTrans,
                              Amount = an.Amount,
                          }).ToList();

            var regExp = (from rt in _context.RegisterTransactions
                          join nt in _context.NameTransactions
                          on rt.NameTransactionId equals nt.Id
                          join tt in _context.TypeTransactions
                          on nt.TypeTransaction equals tt.Id
                          where rt.DateTransaction >= date1 & rt.DateTransaction <= date2 & nt.TypeTransaction == 2
                          select new
                          {
                              rt.Id,
                              rt.DateTransaction,
                              nt.Name,
                              tt.TypeTrans,
                              rt.Amount,
                          }).AsEnumerable()
                          .Select(an => new ModelReport
                          {
                              Id = an.Id,
                              DateTransaction = an.DateTransaction,
                              Name = an.Name,
                              TypeTransaction = an.TypeTrans,
                              Amount = an.Amount,
                          }).ToList();

            sumInc = regInc.Sum(u => u.Amount);
            regInc.Add(new ModelReport { Id = 0, DateTransaction = DateTime.Now, Name = "Total Income for the date:", TypeTransaction = "INCOME", Amount = sumInc });

            sumExp = regExp.Sum(u => u.Amount);
            foreach (var n in regExp)
            {
                regInc.Add(n);
            }
            regInc.Add(new ModelReport { Id = 0, DateTransaction = DateTime.Now, Name = "Total Expenses for the date:", TypeTransaction = "EXPENSE", Amount = sumExp });

            return regInc;
        }
        public Task<ModelReport> UpdateAsync(ModelReport entity)
        {
            throw new NotImplementedException();
        }
    }
}
