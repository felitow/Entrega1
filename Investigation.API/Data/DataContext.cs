using Microsoft.EntityFrameworkCore;
using Investigation.Shared.Entities;


namespace Investigation.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Project>().HasIndex(c => c.NameProject).IsUnique();
        }

    }
}
