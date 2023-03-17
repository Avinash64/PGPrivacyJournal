using PrivacyJournal.API.Models;
using Microsoft.AspNetCore.Mvc;
namespace PrivacyJournal.API.Controllers
{
    [ApiController]
    [Route("api/journal")]
    public class JournalController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Journal> GetJournal()
        {
            return Ok(JournalStore.Current.Journals);
        }        
        [HttpPost]
        public ActionResult<Journal> MakeJournal(object id)
        {
            Console.Write(id);
            JournalStore.Current.Journals.Add(new Journal{Id = 10, Title = "Bruh",Date = DateTime.Now, Entry = "pass"});
            return Ok(JournalStore.Current.Journals);
        }
    }
}