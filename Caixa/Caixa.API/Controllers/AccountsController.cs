using Caixa.Business.Models;
using Caixa.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Caixa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly AccountRepository _accountRepository;

        public AccountsController(AccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        // GET: api/<AccountsController>
        [HttpGet]
        public async Task<IEnumerable<Account>> Get()
        {
            return await _accountRepository.ObterTodasContas();
        }

        // GET api/<AccountsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetId(Guid id)
        {
            var account =  await _accountRepository.ObterContaPorId(id);

            if (account == null) return NotFound();

            return Ok(account);
        }

        // POST api/<AccountsController>
        [HttpPost]
        public async Task<ActionResult<Account>> Post(Account account)
        {
            account.Id = Guid.NewGuid();

            _accountRepository.CriarConta(account);

            return CreatedAtAction("GetId", new { id = account.Id }, account);
        }

        // PUT api/<AccountsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Account>> Put(Guid id, Account account)
        {
            _accountRepository.AtualizarConta(id, account);


            return NoContent();
        }

        // DELETE api/<AccountsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
