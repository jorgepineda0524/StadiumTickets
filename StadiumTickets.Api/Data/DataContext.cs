using Microsoft.EntityFrameworkCore;
using StadiumTickets.Shared.Entities;

namespace StadiumTickets.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(x => x.Id).IsUnique();
        }
    }
}
