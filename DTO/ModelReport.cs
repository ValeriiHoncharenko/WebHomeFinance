using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHomeFinance.DTO
{
    public class ModelReport
    {
        public int Id { get; set; }
        public DateTime DateTransaction { get; set; }
        public string Name { get; set; }
        public string TypeTransaction { get; set; }
        public decimal Amount { get; set; }

    }
}
