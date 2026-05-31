using Abc.Data.Common;

namespace Abc.Data;

public class Creator : NamedEntity {
    public string Type { get; set; } = string.Empty;
    public ICollection<EventCreator> EventCreators { get; set; } = [];
    public ICollection<Event> Events => [.. (EventCreators ?? []).Select(c => c.Event)];
}
