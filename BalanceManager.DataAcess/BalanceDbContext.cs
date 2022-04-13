using System.Data.Entity;

namespace BalanceManager.DataAcess
{
    public class BalanceDbContext : DbContext
    {
        public BalanceDbContext() : base("name=balanceManagerEntities")
        {
            Database.SetInitializer<BalanceDbContext>(null);
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
