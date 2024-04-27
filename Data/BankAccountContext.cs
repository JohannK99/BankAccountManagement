using Microsoft.EntityFrameworkCore;

namespace BankAccountManagement.Data
{
    public class BankAccountContext : DbContext
    {
        public BankAccountContext(DbContextOptions<BankAccountContext> options) : base(options) { }

        // Agrega aquí tus entidades, por ejemplo:
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}