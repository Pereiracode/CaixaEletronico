using Caixa.API.Models;
using Caixa.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Caixa.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options) {}

        public DbSet<Account> Accounts { get; set; }
        public DbSet<BankNote> BankNotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}
