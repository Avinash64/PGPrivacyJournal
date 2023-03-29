namespace PrivacyJournal.API.Models
{
    public class Profile
    {
        public int Id {get; set;}
        public string Username {get;set;} = string.Empty;
        public string Password {get;set;} = string.Empty;
        // public List<int> Journals {get;set;} = new List<int>();
    }
}