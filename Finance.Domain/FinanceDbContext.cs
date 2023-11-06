using Finance.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Finance.Domain
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Entity.Type> Types { get; set; }
    }
}
