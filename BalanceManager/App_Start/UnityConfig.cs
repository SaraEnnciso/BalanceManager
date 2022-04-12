using BalanceManager.Business.Contracts;
using BalanceManager.Business.Implementations;
using BalanceManager.DataAcess.Contracts;
using BalanceManager.DataAcess.Implementations;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace BalanceManager
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IUserBusiness, UserBusiness>();
            container.RegisterType<IUserRepository, UserRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}