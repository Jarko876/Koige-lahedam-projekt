using Abc.Data;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra;

public class SeatsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Seat> (c), ISeatsRepo{}
public class EventsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Event> (c), IEventsRepo{ }
public class HallsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Hall>(c), IHallsRepo { }
public class HallCategoriesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, HallCategory>(c), IHallCategoriesRepo {
    protected override IQueryable<HallCategory> Query() => db.HallCategories
        .Include(x => x.Halls);
}

public class TicketsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Ticket>(c), ITicketsRepo{ }
public class SeatCategoriesRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, SeatCategory>(c), ISeatCategoriesRepo
{ 

}
