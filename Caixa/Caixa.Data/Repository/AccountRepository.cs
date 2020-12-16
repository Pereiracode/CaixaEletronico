using Caixa.Business.Interfaces;
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
    public class AccountRepository : Repository<Account>, IAccountRepository
    {

        public AccountRepository(ApplicationContext context) : base(context)
        {
        }

        //public async Task<Account> Get(Guid id)
        //{
        //    return await _accountrepository.Get(id);
        //}

        //public async Task<IEnumerable<Account>> GetAll()
        //{
        //    return await _accountrepository.GetAll();
        //}

        //public void Save(Account account)
        //{
        //    _accountrepository.Save(account);
        //}

        //public void Update(Account account)
        //{
        //    _accountrepository.Update(account);
        //}

        //public void Delete(Guid id)
        //{
        //    _accountrepository.Delete(id);
        //}


    }
}
