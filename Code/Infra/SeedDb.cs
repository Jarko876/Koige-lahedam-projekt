using System.Diagnostics.Metrics;
using Abc.Aids;
using Abc.Data;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra;

public sealed class SeedDb(ApplicationDbContext db, int recCnt = 20) {
    public async Task Seed() {
        await db.Database.MigrateAsync();
        
        await seedRoles();

        await seedTable(db.Seats, [
            nameof(Seat.HallId),
            nameof(Seat.Hall),
            nameof(Seat.SeatCategory),
            nameof(Seat.SeatCategoryId)]);
        //nameof(Seat.Timestamp)]);

        await seedTable( db.EventSeatCategories, [
            nameof(EventSeatCategory.EventId),
            nameof(EventSeatCategory.SeatCategoryId),
            nameof(EventSeatCategory.Event),
            nameof(EventSeatCategory.SeatCategory)]);

        await seedTable(db.Tickets, [
            nameof(Ticket.SeatId),
            nameof(Ticket.Seat),
            nameof(Ticket.PersonId),
            nameof(Ticket.Person),
            nameof(Ticket.EventObjectId),
            nameof(Ticket.EventObject)]);


        await seedTable(db.SeatCategories, [
            nameof(SeatCategory.EventSeatCategories),
            nameof(SeatCategory.Events)]);

        await seedTable(db.Events, [
            nameof(Event.EventObjects),
            nameof(Event.Feedbacks),
            nameof(Event.EventGenres),
            nameof(Event.Genres)]);

        await seedTable(db.Halls, [
            nameof(Hall.HallCategoryId),
            nameof(Hall.EventObjects),
            nameof(Hall.Seats),
            nameof(Hall.HallCategory)]);

        await seedTable(db.HallCategories, [
            nameof(HallCategory.Halls)]);

        await seedTable(db.Genres);


        await seedTable(db.EventObjects, [
            nameof(EventObject.HallId),
            nameof(EventObject.Hall),
            nameof(EventObject.EventId),
            nameof(EventObject.Event),
            nameof(EventObject.Tickets)]);


        await seedTable(db.EventGenres, [
            nameof(EventGenre.GenreId),
            nameof(EventGenre.EventId),
            nameof(EventGenre.Genre),
            nameof(EventGenre.Event)]);

        await seedTable(db.Carts, [
            nameof(Cart.PersonId),
            nameof(Cart.Person),
            nameof(Cart.Tickets),
            nameof(Cart.Payments)]);

        await seedTable(db.Persons);

        await seedTable(db.Payments, [
            nameof(Payment.CartId),
            nameof(Payment.Cart)]);

        await seedTable(db.Feedbacks, [
            nameof(Feedback.EventId),
            nameof(Feedback.Event)]);

        await seedTable(db.Creators, [
            nameof(Creator.EventCreators),
            nameof(Creator.Events)]);

        await seedTable(db.EventCreators, [
            nameof(EventCreator.EventId),
            nameof(EventCreator.Event),
            nameof(EventCreator.CreatorId),
            nameof(EventCreator.Creator)]);

        await seedTable(db.UserRoles, [
            nameof(UserRole.PersonId),
            nameof(UserRole.Person),
            nameof(UserRole.RoleId),
            nameof(UserRole.Role)]);
    }

    private async Task seedTable<T>(DbSet<T> set, string[] exclude = null) where T : class {
        if (set.Any()) return;
        var items = new List<T>();
        for (var i = 0; i <= recCnt; i++) {
            var item = (T)GetRandom.Object(typeof(T), exclude);
            items.Add(item);
            if (items.Count % 100 != 0) continue;
            await set.AddRangeAsync(items);
            await db.SaveChangesAsync();
            items = [];
        }
        await set.AddRangeAsync(items);
        await db.SaveChangesAsync();
    }
    private async Task seedRoles()
    {
        if (db.Roles.Any()) return;

        await db.Roles.AddRangeAsync(
            new Role
            {
                Name = "User",
                Code = "USR",
                Details = "Regular user"
            },
            new Role
            {
                Name = "Admin",
                Code = "ADM",
                Details = "Administrator"
            },
            new Role
            {
                Name = "SuperAdmin",
                Code = "SUP",
                Details = "Full access administrator"
            });

        await db.SaveChangesAsync();
    }
}