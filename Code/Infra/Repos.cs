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
    { }
    public class HallsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Hall>(c), IHallsRepo
    { }
    public class HallCategoriesRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, HallCategory>(c), IHallCategoriesRepo
    {
        protected override IQueryable<HallCategory> Query() => db.HallCategories
            .Include(x => x.Halls);
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

    }

    public class GenreRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Genre>(c), IGenresRepo
    { }

    public class EventObjectRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, EventObject>(c), IEventObjectsRepo
    {
        protected override IQueryable<EventObject> Query() => db.EventObjects
            .Include(x => x.EventObjectGenres)
            .ThenInclude(x => x.Genre);
    }
    public class EventObjectGenreRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, EventObjectGenre>(c), IEventObjectGenresRepo
    {
        protected override IQueryable<EventObjectGenre> Query() => db.EventObjectGenres
                .Include(x => x.EventObject)
                .Include(x => x.Genre);
    }
    public class TicketsRepo(ApplicationDbContext c = null)
   : EfBaseRepo<ApplicationDbContext, Ticket>(c), ITicketsRepo
    { }

    public class SeatCategoriesRepo(ApplicationDbContext c = null)
   : EfBaseRepo<ApplicationDbContext, SeatCategory>(c), ISeatCategoriesRepo
    {
    }
}
