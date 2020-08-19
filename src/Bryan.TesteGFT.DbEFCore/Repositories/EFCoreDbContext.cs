using Microsoft.EntityFrameworkCore;

namespace Bryan.TesteGFT.DbEFCore.Repositories
{
    public class EfCoreDbContext : DbContext
    {
        public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //domain
        }
    }
}