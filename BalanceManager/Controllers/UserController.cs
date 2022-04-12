using BalanceManager.Business.Contracts;
using BalanceManager.Domain.Model;
using System.Web.Http;

namespace BalanceManager.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserBusiness _business;
        public UserController(IUserBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            User user = _business.Get(1);

            //UserDTO userDTO = new UserDTO
            //{
            //    Login = user.Login,
            //    //role,
            //    USD_balance = user.USD_balance
            //};


            //string user = "hi";

            return Ok(user);
        }
    }
}
