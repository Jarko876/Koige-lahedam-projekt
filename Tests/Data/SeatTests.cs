using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public class SeatTests: BaseTests<Seat>
{
    [TestMethod] public void NumberTest() => isProperty<int>(nameof(Seat.Number));
    [TestMethod] public void RowTest() => isProperty<int>(nameof(Seat.Row));
   
}
