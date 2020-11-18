using System;

namespace Caixa.API.Models
{
    public class BankNote
    {
        public Guid Id { get; set; }
        public EValue Value { get; set; }
        public int Amount { get; set; }
    }
}
