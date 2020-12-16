using Caixa.API.Models;
using Caixa.Business.Interfaces;
using Caixa.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.Data.Repository
{
    public class BankNoteRepository : Repository<BankNote>, IBankNoteRepository
    {
        public BankNoteRepository(ApplicationContext context) : base(context){}



    }
}
