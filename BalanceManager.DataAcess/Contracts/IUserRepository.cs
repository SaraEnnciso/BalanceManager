using BalanceManager.Domain.Model;

namespace BalanceManager.DataAcess.Contracts
{
    public interface IUserRepository
    {
        User Get(int id);

        bool Update(User user);

        bool Delete(User user);
    }

}
