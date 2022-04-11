using BalanceManager.Domain.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BalanceManager.DataAcess
{
    public class BalanceDbContext : DbContext
    {
        public BalanceDbContext()
        {
            Database.SetInitializer<BalanceDbContext>(null);
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
