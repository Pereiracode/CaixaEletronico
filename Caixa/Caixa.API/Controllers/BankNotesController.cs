using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Caixa.API.Models;
using Caixa.Business.Interfaces;
using System.Threading.Tasks;
using System;

namespace Caixa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankNotesController : ControllerBase
    {
        private readonly IBankNoteRepository _banknoteRepository;

        public BankNotesController(IBankNoteRepository banknoteRepository)
        {
            _banknoteRepository = banknoteRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<BankNote>> Get()
        {
            return await _banknoteRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BankNote>> GetId(Guid id)
        {
            var banknote = await _banknoteRepository.Get(id);

            if (banknote == null) return NotFound();

            return Ok(banknote);
        }

        [HttpPost]
        public async Task<ActionResult<BankNote>> Post(BankNote banknote)
        {
            banknote.Id = Guid.NewGuid();

            _banknoteRepository.Save(banknote);

            return CreatedAtAction("GetId", new { id = banknote.Id }, banknote);
        }

        [HttpPut]
        public async Task<ActionResult<BankNote>> Put(BankNote banknote)
        {
            _banknoteRepository.Update(banknote);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BankNote>> Delete(Guid id)
        {
            _banknoteRepository.Delete(id);

            return Ok();

        }
    }
}
