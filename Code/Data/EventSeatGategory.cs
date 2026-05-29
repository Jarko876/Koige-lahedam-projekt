
using Abc.Aids;
using Abc.Data.Common;

namespace Abc.Data
{
    public class EventSeatCategory : NamedEntity
    {
        [Select(typeof(Event))] public Guid? EventId { get; set; }
        [Select(typeof(SeatCategory))] public Guid? SeatCategoryId { get; set; }
        public Event Event { get; set; }
        public SeatCategory SeatCategory { get; set; }

        public int Price { get; set; }
    }
}
