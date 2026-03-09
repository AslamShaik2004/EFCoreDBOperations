using Microsoft.EntityFrameworkCore;

namespace EFCoreDBOperations.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
                new CurrencyType() { Id = 1, Currency = "INR", Description="Indian INR" },
                new CurrencyType() { Id = 2, Currency = "Dollar", Description = "American Dollar" },
                new CurrencyType() { Id = 3, Currency = "Euro", Description = "Europe Euro" },
                new CurrencyType() { Id = 4, Currency = "Dinar", Description = "Kuwait Dinar" }
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title = "Telugu", Description = "Andhra Pradesh - Telugu" },
                new Language() { Id = 2, Title = "Hindi", Description = "India - Hindi" },
                new Language() { Id = 3, Title = "Kannada", Description = "Karnataka - Kannada" },
                new Language() { Id = 4, Title = "Tamil", Description = "Tamilanadu - Tamil" }
                );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<CurrencyType> Currencies { get; set; }
    }
}
