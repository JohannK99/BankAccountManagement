using Microsoft.EntityFrameworkCore;
using BankAccountManagement.Models;

namespace BankAccountManagement.Data
{
    public class BankAccountContext : DbContext
    {
        public BankAccountContext(DbContextOptions<BankAccountContext> options) : base(options) { }

        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}
