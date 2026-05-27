using System.Diagnostics.Metrics;
using Abc.Data;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public class SeatsRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Seat>(c), ISeatsRepo
    { }

    public class EventsRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Event>(c), IEventsRepo
    {
        protected override IQueryable<Event> Query() => db.Events
            .Include(x => x.EventGenres)
            .ThenInclude(x => x.Genre);
    }

    public class HallsRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Hall>(c), IHallsRepo
    { }

    public class HallCategoriesRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, HallCategory>(c), IHallCategoriesRepo
    {
        protected override IQueryable<HallCategory> Query() => db.HallCategories
            .Include(x => x.Halls);
    }

    public class PersonsRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Person>(c), IPersonsRepo
    { }

    public class RolesRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Role>(c), IRolesRepo
    { }

    public class UserRolesRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, UserRole>(c), IUserRolesRepo
    {
        protected override IQueryable<UserRole> Query() => db.UserRoles
            .Include(x => x.Person)
            .Include(x => x.Role);
    }

    public class GenreRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Genre>(c), IGenresRepo
    { }

    public class EventObjectRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, EventObject>(c), IEventObjectsRepo { }

    public class EventGenreRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, EventGenre>(c), IEventGenresRepo
    {
        protected override IQueryable<EventGenre> Query() => db.EventGenres
            .Include(x => x.Event)
            .Include(x => x.Genre);
    }

    public class EventSeatCategoryRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, EventSeatCategory>(c), IEventSeatCategoriesRepo
    {
        protected override IQueryable<EventSeatCategory> Query() => db.EventSeatCategories
            .Include(x => x.Event)
            .Include(x => x.SeatCategory);
    }

    public class TicketsRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Ticket>(c), ITicketsRepo
    { }

    public class SeatCategoriesRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, SeatCategory>(c), ISeatCategoriesRepo
    {
        protected override IQueryable<SeatCategory> Query()
        => db.SeatCategories
            .Include(x => x.EventSeatCategories)
                .ThenInclude(x => x.Event);
    }

    public class PaymentsRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Payment>(c), IPaymentsRepo
    { }

    public class CartsRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Cart>(c), ICartsRepo
    { }
}

