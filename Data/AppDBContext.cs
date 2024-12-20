// File: WebApi3/Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;

namespace WebApi3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<WeatherForecast> WeatherData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>(entity =>
            {
                entity.ToTable("WeatherData");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.TemperatureC).IsRequired();
                entity.Property(e => e.Summary).HasMaxLength(100);
            });
        }
    }
}
