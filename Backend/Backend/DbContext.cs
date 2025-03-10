using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class DbContext
    {
        private DbContextOptions<ApplicationDbContext.ApplicationDbContext> options;

        public DbContext(DbContextOptions<ApplicationDbContext.ApplicationDbContext> options)
        {
            this.options = options;
        }
    }
}