using Caixa.Business.Models;
using Caixa.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa.Data.Repository
{
    public class AccountRepository
    {
        private readonly ApplicationContext _context;
        public AccountRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Account>> ObterTodasContas()
        {
            return await _context.Accounts.ToListAsync();
        }

        public async Task<Account> ObterContaPorId(Guid id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public void CriarConta(Account account)
        {
            _context.Add(account);

            _context.SaveChangesAsync();
        }

        public async Task<bool> AtualizarConta(Guid id, Account account)
        {
            // TODO: resolver problema para atualizar

            if (id != account.Id)
            {
                return false;
            }

            _context.Entry(account).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return true;
        }

    }
}
