using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHomeFinance.DTO;
using WebHomeFinance.Repository;

namespace WebHomeFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        public IRepository<ModelReport> _repos { get; set; }
        public ReportController(IRepository<ModelReport> repos)
        {
            _repos = repos;
        }  

        // GET: ReportController/Details/5
        [HttpGet]
        public   IEnumerable<ModelReport> Get(DateTime date1, DateTime date2)
        {
            if (date2 < new DateTime(1950, 1, 1))
            {
                date2 = date1;
            }
            IEnumerable<ModelReport> res =  _repos.SelectDateAsync(date1, date2);
            return res;
        }   
    }
}
