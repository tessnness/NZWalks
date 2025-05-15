using Microsoft.EntityFrameworkCore;
using NZWalks.API.Controllers.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext: DbContext
    {
        //ctor shortcut
        public NZWalksDbContext(DbContextOptions dbContexOptions) : base(dbContexOptions)
        {
            
        }

        // dbSet properties
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
