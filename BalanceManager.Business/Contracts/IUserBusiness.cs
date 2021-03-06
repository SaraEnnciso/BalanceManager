using BalanceManager.DataAcess;

namespace BalanceManager.Business.Contracts
{
    public interface IUserBusiness
    {
        User Get(User user);

        bool Update(User user);

        bool Delete(User user);
    }
}
