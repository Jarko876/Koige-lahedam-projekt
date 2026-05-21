using System.Diagnostics.Metrics;
using Abc.Data;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra {
     public class SeatsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Seat> (c), ISeatsRepo{}
    public class EventsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Event> (c), IEventsRepo{ }
    public class HallsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Hall>(c), IHallsRepo { }
    public class HallCategoriesRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, HallCategory>(c), IHallCategoriesRepo
    {
        protected override IQueryable<HallCategory> Query() => db.HallCategories
            .Include(x => x.Halls);
    }

    public class GenreRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Genre>(c), IGenresRepo  { }

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


}

