namespace PrivacyJournal.API.Models
{
    public class Journal
    {
        public int Id {get; set;}
        public string Title {get; set;} = string.Empty;
        public DateTime Date {get; set;}
        public string Entry {get; set;} = string.Empty;
        
    }
}