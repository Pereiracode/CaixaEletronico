using System;
using Caixa.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Caixa.Data.Mappings
{
    public class BankNoteMapping : IEntityTypeConfiguration<BankNote>
    {
        public void Configure(EntityTypeBuilder<BankNote> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Amount).IsRequired();
            builder.Property(b => b.Value).IsRequired();

        }
    }
}
