using Microsoft.AspNetCore.Mvc;
using PrivacyJournal.API.Models;

namespace PrivacyJournal.API.Controllers
{
    [ApiController]
    [Route("api/register")]
    public class RegisterController : ControllerBase
    {
        [HttpPost]
        public ActionResult<object> newRegister(Login login)
        {
            var account = ProfileStore.Current.Profiles.FirstOrDefault(c => c.Username == login.Username);
            if (login.Username == null || login.Password == null || account != null){
                return BadRequest(new {success = false});
            }
            var id = ProfileStore.Current.Profiles.Count + 1;
            ProfileStore.Current.Profiles.Add(new Profile(){Id=id, Username = login.Username, Password = login.Password});
            return Ok(new {success = true, id = id});;
        }
    }
}