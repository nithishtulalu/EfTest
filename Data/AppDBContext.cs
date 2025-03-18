using Microsoft.EntityFrameworkCore;
namespace EFTEST.Data

{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
                 new CurrencyType { id = 1, Currency = "INR", Description = "Indian Rupee" },
                 new CurrencyType { id = 2, Currency = "USD", Description = "US Dollar" },
                 new CurrencyType { id = 3, Currency = "EUR", Description = "Euro" },
                 new CurrencyType { id = 4, Currency = "GBP", Description = "British Pound" },
                 new CurrencyType { id = 5, Currency = "JPY", Description = "Japanese Yen" },
                 new CurrencyType { id = 6, Currency = "AUD", Description = "Australian Dollar" },
                 new CurrencyType { id = 7, Currency = "CAD", Description = "Canadian Dollar" });
            modelBuilder.Entity<Language>().HasData(
                new Language { id = 1, Title = "English", Description = "English Language" },
                new Language { id = 2, Title = "Spanish", Description = "Spanish Language" },
                new Language { id = 3, Title = "French", Description = "French Language" },
                new Language { id = 4, Title = "German", Description = "German Language" },
                new Language { id = 5, Title = "Chinese", Description = "Chinese Language" },
                new Language { id = 6, Title = "Japanese", Description = "Japanese Language" },
                new Language { id = 7, Title = "Hindi", Description = "Hindi Language" });
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<CurrencyType> CurrencyTypes { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }

  


    }
}
