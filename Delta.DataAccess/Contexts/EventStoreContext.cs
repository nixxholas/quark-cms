using System.IO;
using Delta.Core.Events;
using Delta.DataAccess.Contexts.Trinity;
using Delta.DataAccess.Mappings.EventStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Delta.DataAccess.Contexts
{
    public class EventStoreContext : DbContext
    {
        public DbSet<StoredEvent> StoredEvent { get; set; }
        
        public EventStoreContext(DbContextOptions<EventStoreContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoredEventMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}