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
    public class RegisterTransactionController : ControllerBase
    {
        public IRepository<RegisterTransaction> _repos { get; set; }
        public RegisterTransactionController(IRepository<RegisterTransaction> repos)
        {
            _repos = repos;
        }
        // GET: api/<RegisterTransaction>
        [HttpGet]
        public IEnumerable<RegisterTransaction> Get()
        {
            return _repos.GetAll();
        }
        [HttpPost]
        public async Task<IActionResult> CreateName([FromBody] RegisterTransaction value)
        {
            return Ok(await _repos.AddAsync(value));
        }
        // PUT api/<RegisterTransaction>/5
        [HttpPut]
        public async Task<IActionResult> UpDateName(int id, [FromBody] RegisterTransaction value)
        {
            return Ok(await _repos.UpdateAsync(value));
        }
        // DELETE api/<RegisterTransaction>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _repos.DeleteAsync(id));
        }
    }    
}
