using System.Data.Entity;

using WindowsServiceMonitor.Ser.Domain.Entities;

namespace WindowsServiceMonitor.Ser.Infrastructure.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection") { }
        public DbSet<Service> Services { get; set; }

        public DbSet<Action> Action { get; set; }
    }
}
