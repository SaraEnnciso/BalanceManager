using BalanceManager.Domain.Model;

namespace BalanceManager.DataAcess.Contracts
{
    public interface IUserRepository
    {
        User Get(User user);

        bool Update(User user);

        bool Delete(User user);
    }

}
