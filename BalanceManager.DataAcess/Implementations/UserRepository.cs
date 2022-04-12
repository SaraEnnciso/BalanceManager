using BalanceManager.DataAcess.Contracts;
using BalanceManager.Domain.Model;
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

        public User Get(int id)
        {
            var roles = (from a in _context.Roles select a).Single();
            return (from a in _context.Users select a).Single();
        }

        public bool Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
