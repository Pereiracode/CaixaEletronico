using Caixa.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Caixa.Data.Mappings
{
    public class AccountMapping : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Holder).IsRequired();
            builder.Property(a => a.Cpf).IsRequired();
            builder.Property(a => a.Balance).IsRequired();

        }
    }
}
