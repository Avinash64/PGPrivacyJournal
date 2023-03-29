using Microsoft.AspNetCore.Mvc;
using PrivacyJournal.API.Entities;
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
            
            using var db = new PrivacyJournalContext();

            var account = db.Accounts.FirstOrDefault(c => c.Username == login.Username);
            if (login.Username == null || login.Password == null || account != null){
                return BadRequest(new {success = false});
            }
            var id = ProfileStore.Current.Profiles.Count + 1;
            Console.WriteLine("Inserting a new blog");
            db.Add(new Profile {Username = login.Username, Password = login.Password});
            db.SaveChanges();
            
            return Ok(new {success = true, id = id});
        }
    }
}