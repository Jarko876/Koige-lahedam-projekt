using Abc.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

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
        public DbSet<Person> Persons { get; set; } = default!;
        public DbSet<Role> Roles { get; set; } = default!;
        public DbSet<UserRole> UserRoles { get; set; } = default!;
        public DbSet<Payment> Payments { get; set; } = default!;
        public DbSet<Cart> Carts { get; set; } = default!;

        public DbSet<Creator> Creators { get; set; } = default!;
        public DbSet<Feedback> Feedbacks { get; set; } = default!;
        
        public DbSet<EventObject> EventObjects { get; set; } = default!;
        public DbSet<EventGenre> EventGenres { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}