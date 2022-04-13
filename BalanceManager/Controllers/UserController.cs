using BalanceManager.Business.Contracts;
using BalanceManager.DataAcess;
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
                RoleDTO = new RoleDTO
                {
                    Description = loggedUser.Role.Description
                },
                USD_balance = loggedUser.USD_balance
            };

            return Ok(loggedUserDTO);
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] UserDTO userDTO)
        {
            if (userDTO == null) return BadRequest("Request is null");

            User user = new User
            {
                Login = userDTO.Login,
                Password = userDTO.Password,
                USD_balance = userDTO.USD_balance
            };

            bool updated = _business.Update(user);

            if (!updated) return BadRequest("Unable to update User");

            var payload = user.Login;

            return Ok("User " + payload + " updated succesfully");

        }
    }
}
