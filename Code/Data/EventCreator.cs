using Abc.Data.Common;


namespace Abc.Data
{
    public class EventCreator : NamedEntity
    {
        public int Id { get; set; }
        public int EventId { get; set; }

        public int CreatorId { get; set; }
        public Creator Creator { get; set; }
    }
}
