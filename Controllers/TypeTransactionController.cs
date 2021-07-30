using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHomeFinance.Models;
using WebHomeFinance.Repository;

namespace WebHomeFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeTransactionController : ControllerBase
    {     
            public IRepository<TypeTransaction> _repos { get; set; }
            public TypeTransactionController(IRepository<TypeTransaction> repos)
            {
                _repos = repos;
            }
           
            [HttpGet]
            public IEnumerable<TypeTransaction> Get()
            {
                return _repos.GetAll();
            }
       
    }
}
