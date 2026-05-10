using Abc.Data.Common;

namespace Abc.Data;

public sealed class Hall : NamedEntity  {
    public int NrOfSeats { get; set; }
    public int NrOfRows { get; set; }
    public string City { get; set; }
    public string Address { get; set; }

}
