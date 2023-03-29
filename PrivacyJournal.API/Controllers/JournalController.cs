using PrivacyJournal.API.Models;
using Microsoft.AspNetCore.Mvc;
using PrivacyJournal.API.Entities;
namespace PrivacyJournal.API.Controllers
{
    [ApiController]
    [Route("api/journal")]
    public class JournalController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Journal> GetJournal()
        {

            using var db = new PrivacyJournalContext();
            return Ok(db.Journals.ToList());
        }        
        [HttpPost]
        public ActionResult<Journal> MakeJournal(Journal journal)
        {

            using var db = new PrivacyJournalContext();
            var date  = DateTime.Now;
            var j = new Journal{Title = journal.Title, Date = date, Entry = journal.Entry};
            db.Journals.Add(j);

            db.SaveChanges();
            return Ok(db.Journals.FirstOrDefault(c=> c.Date == date));
        }
    }
}