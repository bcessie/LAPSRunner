using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Runner.Models;
using System.Configuration;
using System.Reflection;

namespace Runner.Data
{
    public class RunnerDbContext : DbContext
    {
        public DbSet<AppInstance> AppInstances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string value = ConfigurationManager.ConnectionStrings["RunnerConnection"].ConnectionString;
            var runningDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            runningDirectory = Path.Combine(runningDirectory, value);
            optionsBuilder.UseSqlite("Data Source=" + runningDirectory);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppInstance>(builder =>
            {
                builder.ToTable("AppInstances");

                builder.HasKey(p => p.Id);

                builder.Property(p => p.Name).HasMaxLength(100);

                builder.Property(p => p.Path).HasMaxLength(1000);
            });
        }
    }
}
