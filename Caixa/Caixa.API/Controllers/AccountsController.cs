using Caixa.Business.Interfaces;
using Caixa.Business.Models;
using Caixa.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountsController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Account>> Get()
        {
            return await _accountRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetId(Guid id)
        {
            var account =  await _accountRepository.Get(id);

            if (account == null) return NotFound();

            return Ok(account);
        }

        [HttpPost]
        public async Task<ActionResult<Account>> Post(Account account)
        {
            account.Id = Guid.NewGuid();

            _accountRepository.Save(account);

            return CreatedAtAction("GetId", new { id = account.Id }, account);
        }

        [HttpPut]
        public async Task<ActionResult<Account>> Put(Account account)
        {
            _accountRepository.Update(account);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Account>> Delete(Guid id)
        {
            _accountRepository.Delete(id);

            return Ok();

        }
    }
}
