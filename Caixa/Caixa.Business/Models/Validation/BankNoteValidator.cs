using Caixa.API.Models;
using FluentValidation;

namespace Caixa.Business.Models.Validation
{
    public class BankNoteValidator : AbstractValidator<BankNote>
    {
        public BankNoteValidator()
        {
            RuleFor(b => b.Value).NotNull();
            RuleFor(b => b.Amount).NotNull();
        }
    }
}
