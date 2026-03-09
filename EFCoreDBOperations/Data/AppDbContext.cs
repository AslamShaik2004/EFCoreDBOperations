using Microsoft.EntityFrameworkCore;

namespace EFCoreDBOperations.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
    }
}
