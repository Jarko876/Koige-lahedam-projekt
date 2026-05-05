using Abc.Data.Common;
using System.Reflection.Metadata;

//vastutab Allan

namespace Abc.Data
{
    public class Ticket : BaseEntity
    {
        //kes ostis pileti
        public int PersonId { get; set; }


        //public User User { get; set; } - pole veel klassi tehtud, hiljem tagasi panna.

        //millisele kohale
        public int SeatId { get; set; }
        public Seat Seat { get; set; }


        //millisele üritusele
        public int EventId { get; set; }
        public Event Event { get; set; }


        //lõplik hind , mis võib sisaldada allahindlust või muid hinnamuutusi(vaja meetod teha)
        public decimal FinalPrice { get; set; }

    }
}
