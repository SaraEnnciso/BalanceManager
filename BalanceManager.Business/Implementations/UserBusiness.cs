using BalanceManager.Business.Contracts;
using BalanceManager.DataAcess.Contracts;
using BalanceManager.Domain.Model;
using System;

namespace BalanceManager.Business.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _repository;

        public UserBusiness(IUserRepository repository)
        {
            _repository = repository;
        }

        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }

        public User Get(User user)
        {
            if (user.Login == null || user.Password == null) return null;

            return _repository.Get(user);
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
