using Abc.Data;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatCategory> SeatCategories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Event> Events { get; set; } = default!;
        public DbSet<Hall> Halls { get; set; } = default!;
        public DbSet<HallCategory> HallCategories { get; set; } = default!;
        public DbSet<EventObject> EventObjects { get; set; } = default!;
        public DbSet<EventObjectGenre> EventObjectGenres { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            builder.Entity<Seat>()
                .HasOne(s => s.SeatCategory)
                .WithMany()
                .HasForeignKey(s => s.SeatCategoryId);

            builder.Entity<Ticket>()
                .Property(p => p.FinalPrice)
                .HasPrecision(10, 2);
        }
    }
}