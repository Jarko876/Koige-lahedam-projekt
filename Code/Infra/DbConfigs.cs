using System.Diagnostics.Metrics;
using Abc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Abc.Infra;

public sealed class HallConfig : IEntityTypeConfiguration<Hall>{
    public void Configure(EntityTypeBuilder<Hall> builder) { 
        builder.HasOne(x => x.HallCategory)
            .WithMany(x => x.Halls)
            .HasForeignKey(x => x.HallCategoryId);
    }
}
public sealed class HallCategoryConfig : IEntityTypeConfiguration<HallCategory> {
    public void Configure(EntityTypeBuilder<HallCategory> builder) {
    }
}
public sealed class SeatCategoryConfig : IEntityTypeConfiguration<SeatCategory> {
    public void Configure(EntityTypeBuilder<SeatCategory> builder) { }
}
public sealed class EventConfig : IEntityTypeConfiguration<Event> {
    public void Configure(EntityTypeBuilder<Event> builder) {
        builder.HasMany(x => x.EventGenres)
            .WithOne(x => x.Event)
            .HasForeignKey(x => x.EventId);
    }
}
public sealed class SeatConfig : IEntityTypeConfiguration<Seat> {
    public void Configure(EntityTypeBuilder<Seat> builder) {
        builder.HasOne(x => x.SeatCategory)
            .WithMany()
            .HasForeignKey(x => x.SeatCategoryId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
public sealed class TicketConfig : IEntityTypeConfiguration<Ticket> {
    public void Configure(EntityTypeBuilder<Ticket> builder) {
        builder.Property(x => x.FinalPrice).HasPrecision(18, 2);
    }
}
public sealed class PersonConfig : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
    }
}

public sealed class RoleConfig : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
    }
}

public sealed class UserRoleConfig : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId);

        builder.HasOne(x => x.Role)
            .WithMany()
            .HasForeignKey(x => x.RoleId);

        builder.HasIndex(x => new { x.PersonId, x.RoleId }).IsUnique();
    }
}

public sealed class PaymentConfig : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.Property(x => x.Amount).HasPrecision(18, 2);
        builder.HasOne(x => x.Cart)
            .WithMany()
            .HasForeignKey(x => x.CartId);
    }
}

/*
public sealed class CartConfig : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasMany(x => x.Tickets)
            .WithOne()  // Remove .WithOne(x => x.Cart) since Ticket doesn't have Cart property
            .HasForeignKey(x => x.CartId);
    }
} */

public sealed class GenreConfig : IEntityTypeConfiguration<Genre> {
    public void Configure(EntityTypeBuilder<Genre> builder) { }
}

public sealed class EventObjectConfig : IEntityTypeConfiguration<EventObject>
{
    public void Configure(EntityTypeBuilder<EventObject> builder) {
       
    }
}
public sealed class EventGenreConfig : IEntityTypeConfiguration<EventGenre>
{
    public void Configure(EntityTypeBuilder<EventGenre> builder) {
        builder.HasOne(x => x.Event)
            .WithMany(x => x.EventGenres)
            .HasForeignKey(x => x.EventId);
        builder.HasOne(x => x.Genre).WithMany().HasForeignKey(x => x.GenreId);
    }
}

//public sealed class CountryCurrencyConfig : IEntityTypeConfiguration<CountryCurrency>{
//    public void Configure(EntityTypeBuilder<CountryCurrency> builder)
//    {
//        b.HasOne(x => x.Country)
//            .WithMany(x => x.CountryCurrencies)
//            .HasForeignKey(x => x.CountryId);
//        b.HasOne(x => x.Currency).WithMany().HasForeignKey(x => x.CurrencyId);
//    }
//}
//public sealed class CountryConfig : IEntityTypeConfiguration<Country> {
//    public void Configure(EntityTypeBuilder<Country> builder)
//    {
//        b.HasMany(x => x.CountryCurrencies)
//            .WithOne(x => x.Country)
//            .HasForeignKey(x => x.CountryId);
//    }
//}