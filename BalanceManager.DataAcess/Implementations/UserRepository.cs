using BalanceManager.DataAcess.Contracts;
using BalanceManager.Domain.Model;
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

        //private List<User> MockData()
        //{
        //    List<User> mockData = new List<User>();
        //    mockData.Add(new User { Login = "melverston0", Password = "wx2GEErjJcRy", Id_role = 1, USD_balance = 619112.5 });
        //    mockData.Add(new User { Login = "bfraschini1", Password = "WOD96KGvN", Id_role = 1, USD_balance = 109278.97 });
        //    mockData.Add(new User { Login = "akeyho2", Password = "VjsXIyc", Id_role = 2, USD_balance = 53080.57 });
        //    mockData.Add(new User { Login = "jashtonhurst3", Password = "IGSHI6xtPvZ", Id_role = 2, USD_balance = 147174.79 });
        //    mockData.Add(new User { Login = "ccow4", Password = "C0GeMYvF8", Id_role = 2, USD_balance = 566347.49 });

        //    return mockData;
        //}

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
