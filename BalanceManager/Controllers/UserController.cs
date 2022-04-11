using System.Web.Http;

namespace BalanceManager.Controllers
{
    [RoutePrefix("User")]
    public class UserController : ApiController
    {
        //private readonly IUserBusiness _business;
        //public UserController(IUserBusiness business)
        //{
        //    _business = business;
        //}

        [Route("")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            string result = "bien";

            return Ok(result);
        }
    }
}
