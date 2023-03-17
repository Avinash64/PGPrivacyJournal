using PrivacyJournal.API.Models;

public class ProfileStore
{
    public List<Profile> Profiles {get; set;}

    public static ProfileStore Current {get;} = new ProfileStore();

    public ProfileStore()
    {
        Profiles = new List<Profile>(){
            new Profile {
                Id = 1,
                Username = "user1",
                Password = "password"
            },
            new Profile {
                Id = 2,
                Username = "user2",
                Password = "password"
            },
            new Profile {
                Id = 3,
                Username = "user3",
                Password = "password"
            },
        };
    }
}