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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed data for difficulties: Easy, Medium, Hard
            var difficulties = new List<Difficulty>()
            {
                new Difficulty() {
                    Id = Guid.Parse("16bdc40b-10a3-4641-8baf-cbf22181cfbc"),
                    Name = "Easy"
                },

                new Difficulty() {
                    Id = Guid.Parse("39f6a494-1bcd-4479-9cc0-57d85401833c"),
                    Name = "Medium"
                },

                new Difficulty() {
                    Id = Guid.Parse("2a822851-5abe-4fa0-848d-2113f15e9b6e"),
                    Name = "Hard"
                }
            };

            //Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            //Seed data for regions
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("84a04711-e402-43d2-9ff9-2549e2c169e0"),
                    Code = "AKL",
                    Name = "Auckland",
                    RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.earthtrekkers.com%2Fauckland-itinerary%2F&psig=AOvVaw2s8i9SRBtXjjjf7RsnlXqB&ust=1748608465176000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCNCCmKvYyI0DFQAAAAAdAAAAABAE"
                },

                new Region()
                {
                    Id = Guid.Parse("0d9676bc-ed5f-4dcb-ab4c-e637d4f74c5a"),
                    Code = "WGN",
                    Name = "Wellington",
                    RegionImageUrl = null
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);

        }
    }
}
