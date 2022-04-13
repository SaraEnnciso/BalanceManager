using BalanceManager.Domain.Model;
using System.Data.Entity;

namespace BalanceManager.DataAcess
{
    public class BalanceDbContext : DbContext
    {
        public BalanceDbContext() : base("name=BalanceDbContext")
        {
            Database.SetInitializer<BalanceDbContext>(null);
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
