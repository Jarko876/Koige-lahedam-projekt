using System.Diagnostics.Metrics;
using Abc.Aids;
using Abc.Data;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra;

public sealed class SeedDb(ApplicationDbContext db, int recCnt = 20) {
    public async Task Seed() {
        await db.Database.MigrateAsync();
        
        await seedRoles();

        await seedTable(db.Seats);
        //nameof(Seat.Timestamp)]);

        await seedTable(db.Events, [
            nameof(Event.EventGenres),
            nameof(Event.Genres)]);

        await seedTable(db.Halls, [
            nameof(Hall.HallCategoryId),
            nameof(Hall.HallCategory)]);

        await seedTable(db.HallCategories, [
            nameof(HallCategory.Halls)]);

        await seedTable(db.Genres);


        await seedTable(db.EventObjects);


        await seedTable(db.EventGenres, [
            nameof(EventGenre.GenreId),
            nameof(EventGenre.EventId),
            nameof(EventGenre.Genre),
            nameof(EventGenre.Event)]);
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