using BalanceManager.DataAcess.Contracts;
using System.Data.Entity;
using System.Linq;

namespace BalanceManager.DataAcess.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly BalanceDbContext _context;

        public UserRepository(BalanceDbContext context)
        {
            _context = context;
        }

        public bool Delete(User user)
        {
            throw new System.NotImplementedException();
        }

        public User Get(User userCredentials)
        {
            User user = new User();

            using (var db = new BalanceDbContext())
            {
                user = db.Users.Where(a => a.Login == userCredentials.Login && a.Password == userCredentials.Password)
                                .Include("Role")
                                .FirstOrDefault();
            }

            return user;
        }

        public bool Update(User user)
        {
            using (var db = new BalanceDbContext())
            {
                User userRecord = db.Users.SingleOrDefault(a => a.Login == user.Login);

                if (userRecord == null) return false;

                db.Users.Attach(user);
                db.Entry(user).Property(q => q.USD_balance).IsModified = true;

                db.SaveChanges();

                return true;
            }

        }
    }
}
