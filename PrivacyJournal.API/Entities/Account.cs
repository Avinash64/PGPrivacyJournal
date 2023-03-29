using Microsoft.EntityFrameworkCore;
using PrivacyJournal.API.Models;

namespace PrivacyJournal.API.Entities
{
    public class PrivacyJournalContext : DbContext
{
    public DbSet<Profile> Accounts {get; set;}
    public DbSet<Journal> Journals {get; set;}

    public string DbPath { get; }

    public PrivacyJournalContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "journal.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");



}}