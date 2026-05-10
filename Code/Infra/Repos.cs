using Abc.Data;

namespace Abc.Infra;

public class SeatsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Seat> (c), ISeatsRepo{}
public class EventsRepo(ApplicationDbContext c = null)
    : EfBaseRepo<ApplicationDbContext, Event> (c), IEventsRepo{ }

