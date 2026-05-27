using Abc.Aids;
using Abc.Data.Common;

//vastutab Allan

namespace Abc.Data
{
    public class Seat : NamedEntity
    {

        public int Number { get; set; }
        public int Row { get; set; }

        public Guid? HallId { get; set; }
        public Hall Hall { get; set; } 

        public Guid? SeatCategoryId { get; set; }
        public SeatCategory SeatCategory { get; set; }


    }
}
