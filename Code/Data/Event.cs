using Abc.Data.Common;
using System.ComponentModel;

namespace Abc.Data;

public class Event : NamedEntity {
    [DisplayName("Title")]public override string Name { get; set; }
    [DisplayName("Description")] public override string Details { get; set; }
    public string EventType { get; set; }
    public string HallType { get; set; }
    public int durationMinutes { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
    //public ICollection<EventEventGenre> EventEventGenres { get; set; } = [];
    //public ICollection<EventObject> EventObjects {  get; set; } = [];
}
