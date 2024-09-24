using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IND"
                },
                new Country
                {
                    Id = 2,
                    Name = "Germany",
                    ShortName = "GER"
                },
                new Country
                {
                    Id = 3,
                    Name = "Ireland",
                    ShortName = "IRE"
                }

             );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Taj Hotel",
                    Address = "Mumbai",
                    CountryId = 1,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "Berlin",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Casteltroy Park",
                    Address = "Limrick",
                    CountryId = 3,
                    Rating = 5
                }
              );
        }
    }
}
