using Abc.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra {
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options) {
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatCategory> SeatCategories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Event> Events { get; set; } = default!;
        public DbSet<Hall> Halls { get; set; } = default!;
        public DbSet<HallCategory> HallCategories { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Seat>()
                .HasOne(s => s.SeatCategory)
                .WithMany()
                .HasForeignKey(s => s.SeatCategoryId);

            modelBuilder.Entity<Ticket>()
                .Property(p => p.FinalPrice)
                .HasPrecision(10, 2);
        }

    }

   
}
