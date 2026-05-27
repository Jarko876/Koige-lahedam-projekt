using Abc.Data.Common;

//vastutab Allan

namespace Abc.Data
{
    public class SeatCategory : NamedEntity
    {
        public ICollection<EventSeatCategory> EventSeatCategories { get; set; } = [];
    }
}
