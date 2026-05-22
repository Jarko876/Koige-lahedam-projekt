using Abc.Aids;
using Abc.Data.Common;

namespace Abc.Data;

public sealed class Hall : NamedEntity  {
    public int NrOfSeats { get; set; }
    public int NrOfRows { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    [Select(typeof(HallCategory))]public Guid? HallCategoryId { get; set; }
    public HallCategory HallCategory { get; set; }
    public ICollection<EventObject> EventObjects { get; set; } = [];
}
