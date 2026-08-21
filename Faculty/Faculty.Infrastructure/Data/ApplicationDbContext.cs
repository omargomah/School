using Microsoft.EntityFrameworkCore;
namespace Faculty.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext):DbContext(dbContext)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
