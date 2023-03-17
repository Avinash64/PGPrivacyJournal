using PrivacyJournal.API.Models;

public class JournalStore
{
    public List<Journal> Journals {get; set;}

    public static JournalStore Current {get;} = new JournalStore();

    public JournalStore()
    {
        Journals = new List<Journal>(){
            new Journal {
                Id = 1,
                Title = "title",
                Date = DateTime.Now,
                Entry = "password"
            },
            new Journal {
                Id = 2,
                Title = "title",
                Date = DateTime.Now,
                Entry = "password"
            },
            new Journal {
                Id = 3,
                Title = "title",
                Date = DateTime.Now,
                Entry = "password"
            }
        };
    }
}