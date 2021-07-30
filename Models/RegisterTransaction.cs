using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebHomeFinance.Models
{
    public class RegisterTransaction
    {
        public int Id { get; set; }       
        public DateTime DateTransaction { get; set; }        
        public int NameTransactionId { get; set; }          
        public decimal Amount { get; set; }
               
    }
}
