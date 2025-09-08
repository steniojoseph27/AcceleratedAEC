using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<ModelSnapshot> ModelSnapshots => Set<ModelSnapshot>();
        public DbSet<ContextEvent> ContextEvents => Set<ContextEvent>();
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModelSnapshot>()
                .HasIndex(x => x.SessionId);
        } 
    }  
}