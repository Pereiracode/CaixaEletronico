using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Caixa.API.Models;

namespace Caixa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankNotesController : ControllerBase
    {
        // GET: api/<BankNotesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BankNotesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BankNotesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BankNotesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BankNotesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
