using Microsoft.AspNetCore.Mvc;
using PrivacyJournal.API.Models;

namespace PrivacyJournal.API.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public ActionResult<object> GetLogin(Login login)
        {
            var account = ProfileStore.Current.Profiles.FirstOrDefault(c => c.Username == login.Username);
            if (account == null){
                return Unauthorized(new {success = false});
            }
            if (account.Password == login.Password){
                return Ok( new {success = true});
            }
            return Unauthorized(new {success = false});;
        }
    }
}