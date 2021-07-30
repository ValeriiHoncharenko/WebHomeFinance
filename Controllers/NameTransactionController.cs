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
    public class NameTransactionController : ControllerBase
    {       
        public IRepository<NameTransaction> _repos { get; set; }
        public NameTransactionController(IRepository<NameTransaction> repos)
        {
            _repos = repos;
        }

        // GET: api/<NameTransaction>
        [HttpGet] 
        public IEnumerable<NameTransaction> Get()
        {
            return _repos.GetAll();
        }

        // GET api/<NameTransaction>/5
        [HttpGet("{id}")]
        public  ActionResult<NameTransaction> Get(int id)
        {            
            return  Ok(_repos.FindByIdAsync(id));
        }

        // POST api/<NameTransaction>
        [HttpPost]
        public async Task<IActionResult> CreateName([FromBody] NameTransaction value)
        {
            return Ok(await _repos.AddAsync( value));    
        }

        // PUT api/<NameTransaction>/5
        [HttpPut]
        public async Task<IActionResult> UpDateName(int id,[FromBody] NameTransaction value)
        {
           return Ok(await _repos.UpdateAsync(value));
        }

        // DELETE api/<NameTransaction>/5
        [HttpDelete("{id}")]
       public async Task<IActionResult> Delete(int id)
        {           
           return Ok(await _repos.DeleteAsync(id));
        }
    }
}
