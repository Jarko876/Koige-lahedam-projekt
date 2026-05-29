using Abc.Data.Common;

//vastutab Allan

namespace Abc.Data
{
    public class Ticket : NamedEntity
    {
  
        public int PersonId { get; set; }

        public Person Person { get; set; } 

        public Guid? SeatId { get; set; }
        public Seat Seat { get; set; }


        public Guid? EventId { get; set; }
        public Event Event { get; set; }


        public decimal FinalPrice { get; set; }

    }
}
