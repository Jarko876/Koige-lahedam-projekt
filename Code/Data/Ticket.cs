using Abc.Aids;
using Abc.Data.Common;

//vastutab Allan

namespace Abc.Data;

public class Ticket : NamedEntity {
    public Guid? SeatId { get; set; }
    public Seat Seat { get; set; }

    public Guid? PersonId { get; set; }
    public Person Person { get; set; }
    public Guid? CartId { get; set; }
    public Cart Cart { get; set; }

    public Guid? EventObjectId { get; set; }
    public EventObject EventObject { get; set; }


    public decimal FinalPrice { get; set; }

}
