using BalanceManager.Domain.Model;

namespace BalanceManager.Business.Contracts
{
    public interface IUserBusiness
    {
        User Get(int id);

        bool Update(User user);

        bool Delete(User user);
    }
}
