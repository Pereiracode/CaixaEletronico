using System;

namespace Caixa.Business.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Holder { get; set; }
        public string Cpf { get; set; }
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }

            return false;
        }
    }
}
