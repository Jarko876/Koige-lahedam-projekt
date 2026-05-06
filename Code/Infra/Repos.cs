using Abc.Data;


namespace Abc.Infra
{
    public class SeatsRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Seat> (c), ISeatsRepo{}

    
}
