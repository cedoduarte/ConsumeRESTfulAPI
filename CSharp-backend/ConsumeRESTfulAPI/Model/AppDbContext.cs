using ConsumeRESTfulAPI.Model.Interface;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.Model
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IAppDbContext).Assembly);
        }
    }
}
