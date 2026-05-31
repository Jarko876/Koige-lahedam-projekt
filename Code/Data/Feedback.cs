using Abc.Aids;
using Abc.Data.Common;

namespace Abc.Data;

public class Feedback : NamedEntity {
    public string content { get; set; } = string.Empty;
    [Select(typeof(Event))]public Guid? EventId { get; set; }
    public Event? Event { get; set; }
}
