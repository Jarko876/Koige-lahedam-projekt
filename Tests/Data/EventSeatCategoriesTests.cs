using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public class EventSeatCategoryTests: BaseTests<EventSeatCategory>
{
    [TestMethod] public void PriceTest() => isProperty<int>(nameof(EventSeatCategory.Price));
}
