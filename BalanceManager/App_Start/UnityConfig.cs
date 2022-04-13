using BalanceManager.App_Start;
using BalanceManager.Business.Contracts;
using BalanceManager.Business.Implementations;
using BalanceManager.DataAcess.Contracts;
using BalanceManager.DataAcess.Implementations;
using System.Web.Http;
using Unity;

namespace BalanceManager
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserBusiness, UserBusiness>();
            container.RegisterType<IUserRepository, UserMockRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityResolver(container);
        }
    }
}