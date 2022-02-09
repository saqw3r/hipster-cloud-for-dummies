using Microsoft.EntityFrameworkCore;

namespace Hipster.Api
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Book> Books { get; init; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book 
                {
                    Id = 1,
                    Title = "Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    Year = 1954,
                    ISBN = "1234567890",
                    Description = "A great book!",
                    CoverImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b0/Tloftr-logo.svg/1920px-Tloftr-logo.svg.png"
                },
                new Book { 
                    Id = 2,
                    Title = "Harry Potter",
                    Author = "J.K. Rowling",
                    Year = 1997,
                    ISBN = "9876543210",
                    Description = "A great book!",
                    CoverImageUrl = "https://m.media-amazon.com/images/M/MV5BNjQ3NWNlNmQtMTE5ZS00MDdmLTlkZjUtZTBlM2UxMGFiMTU3XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg"
                },
                new Book { 
                    Id = 3,
                    Title = "Lonely Planet",
                    Author = "Tom De Smedt",
                    Year = 2004,
                    ISBN = "0987654321",
                    Description = "A great book!",
                    CoverImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9b/Lonely_Planet_Australia_travel_guide_16th_Edition.png"
                }
            );
        }
    }
}