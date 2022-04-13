using BalanceManager.DataAcess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BalanceManager.DataAcess.Implementations
{
    public class UserMockRepository : IUserRepository
    {
        private List<User> Users = new List<User>{
            new User { Login = "matt05", Password = "a54R32hj", USD_balance = 804581.29, Role = new Role{ Description = "admin" } },
            new User { Login = "jscarris3", Password = "a6G57jU", USD_balance = 132940.11, Role = new Role{ Description = "user" } }
        };

        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }

        public User Get(User userCredentials)
        {
            User user = Users.Where(a => a.Login == userCredentials.Login && a.Password == userCredentials.Password).FirstOrDefault();

            return user;
        }

        public bool Update(User user)
        {
            User userRecord = Users.SingleOrDefault(a => a.Login == user.Login);

            if (userRecord == null) return false;

            userRecord.USD_balance = user.USD_balance;

            return true;
        }
    }
}
