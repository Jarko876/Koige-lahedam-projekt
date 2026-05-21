using Abc.Data.Common;

//vastutab Allan

namespace Abc.Data
{
    public class Ticket : NamedEntity
    {
        //kes ostis pileti
        public int PersonId { get; set; }


        //public User User { get; set; } - pole veel klassi tehtud, hiljem tagasi panna.

        //millisele kohale
        public Guid? SeatId { get; set; }
        public Seat Seat { get; set; }


        //millisele üritusele
        public Guid? EventId { get; set; }
        public Event Event { get; set; }


        //lõplik hind , mis võib sisaldada allahindlust või muid hinnamuutusi(vaja meetod teha)
        public decimal FinalPrice { get; set; }

    }
}
