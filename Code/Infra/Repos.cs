using Abc.Data;


namespace Abc.Infra
{
    public class SeatsRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Seat> (c), ISeatsRepo{}


    public class GenreRepo(ApplicationDbContext c = null)
        : EfBaseRepo<ApplicationDbContext, Genre>(c), IGenresRepo
    { }

}
