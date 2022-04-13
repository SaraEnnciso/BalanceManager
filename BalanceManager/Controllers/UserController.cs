using BalanceManager.Business.Contracts;
using BalanceManager.Domain.Model;
using BalanceManager.DTO;
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

        [HttpPost]
        public IHttpActionResult Login([FromBody] UserDTO userDTO)
        {
            if (userDTO == null) return BadRequest("Request is null");

            User userToLogIn = new User
            {
                Login = userDTO.Login,
                Password = userDTO.Password
            };

            User loggedUser = _business.Get(userToLogIn);

            if (loggedUser == null) return NotFound();

            UserDTO loggedUserDTO = new UserDTO
            {
                Login = loggedUser.Login,
                USD_balance = loggedUser.USD_balance
            };

            return Ok(loggedUserDTO);
        }
    }
}
