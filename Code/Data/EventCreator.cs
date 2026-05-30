using Abc.Aids;
using Abc.Data.Common;


namespace Abc.Data
{
    public class EventCreator : NamedEntity
    {

        [Select(typeof(Event))]
        public Guid? EventId { get; set; }
        public Event? Event { get; set; }

        [Select(typeof(Creator))]
        public Guid? CreatorId { get; set; }
        public Creator? Creator { get; set; }
    }
}
