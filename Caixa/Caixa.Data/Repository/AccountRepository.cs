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
    }
}
