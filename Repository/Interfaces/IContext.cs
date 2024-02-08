using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<NameForPrayer> NameForPrayers { get; set; }
        public DbSet<ChaptersOfTehilim> ChaptersOfTehilims { get; set; }
        public DbSet<RequestPrayer> RequestPrayers { get; set; }
        public DbSet<Sharing> Sharings { get; set; }
        public DbSet<ChaptersTehilimToRead> ChaptersTehilimToReads { get; set; }
        public Task Save();

    }
}
