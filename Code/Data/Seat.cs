using Abc.Data.Common;

//vastutab Allan

namespace Abc.Data
{
    public class Seat : NamedEntity
    {

        public int Number { get; set; }
        public int Row { get; set; }

        public int HallId { get; set; }
        //public Hall Hall { get; set; } - hiljem tagasi panna, Hall on hetkel internal ja siin hakkab errorit andma.

        public int SeatCategoryId { get; set; }
        public SeatCategory SeatCategory { get; set; }


    }
}
