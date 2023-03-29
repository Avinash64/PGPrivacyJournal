using Microsoft.AspNetCore.Mvc;
using PrivacyJournal.API.Entities;
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
            
        using var db = new PrivacyJournalContext();


            // var account = ProfileStore.Current.Profiles.FirstOrDefault(c => c.Username == login.Username);
            // Console.WriteLine("Querying for a blog");
var account = db.Accounts
    .OrderBy(b => b.Id)
    .FirstOrDefault(c => c.Username == login.Username);
    Console.WriteLine(account);

            if (account == null){
                return Unauthorized(new {success = false, bruh="bruh"});
            }
            if (account.Password == login.Password){
    
                return Ok( new {success = true});
            }
            return Unauthorized(new {success = false});
            
        }
    }
}