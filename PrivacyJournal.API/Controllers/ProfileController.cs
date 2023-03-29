using PrivacyJournal.API.Models;
using Microsoft.AspNetCore.Mvc;
namespace PrivacyJournal.API.Controllers
{
    [ApiController]
    [Route("api/profile")]
    public class ProfileController : ControllerBase
    {
            
        [HttpGet]
        public ActionResult<Profile> GetProfile()
        {
            return Ok(ProfileStore.Current.Profiles);
        }        
        [HttpPost]
        public ActionResult<Profile> MakeProfile()
        {
            ProfileStore.Current.Profiles.Add(new Profile{Id = 10, Username = "Bruh", Password = "pass"});
            return Ok(ProfileStore.Current.Profiles);
        }
        [HttpGet("{id}")]
        public ActionResult<Profile> GetSingleProfile(int id)
        {
            return Ok(ProfileStore.Current.Profiles.FirstOrDefault(c=>c.Id == id));
        }        
    }



}