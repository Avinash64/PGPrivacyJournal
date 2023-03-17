using Microsoft.AspNetCore.Mvc;
using PrivacyJournal.API.Models;

namespace PrivacyJournal.API.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public string GetLogin(Login login)
        {
            var account = ProfileStore.Current.Profiles.FirstOrDefault(c => c.Username == login.Username);
            if (account == null){
                return "Login Failed";
            }
            if (account.Password == login.Password){
                return "Login Successful";
            }
            return "Login Failed";
        }
    }
}