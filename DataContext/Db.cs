using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interfaces;

namespace DataContext
{
    public class Db : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<NameForPrayer> NameForPrayers { get; set; }
        public DbSet<ChaptersOfTehilim> ChaptersOfTehilims { get; set; }
        public DbSet<RequestPrayer> RequestPrayers { get; set; }
        public DbSet<Sharing> Sharings { get; set; }

        public DbSet<ChaptersTehilimToRead> ChaptersTehilimToReads { get; set; }

        public async Task  Save()
        {
            await SaveChangesAsync();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=myDataBase;trusted_connection=true;TrustServerCertificate=true");
        }
    }
}