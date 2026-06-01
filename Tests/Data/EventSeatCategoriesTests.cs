using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public class EventSeatCategoryTests: BaseTests<EventSeatCategory>
{
    [TestMethod] public void PriceTest() => isProperty<int>(nameof(EventSeatCategory.Price));

    [TestMethod]
    public void IdTest() =>
        isProperty<Guid>(nameof(EventSeatCategory.Id));

    [TestMethod]
    public void DetailsTest() =>
        isProperty<string>(nameof(EventSeatCategory.Details));

    [TestMethod]
    public void NameTest() =>
        isProperty<string>(nameof(EventSeatCategory.Name));

    [TestMethod]
    public void CodeTest() =>
        isProperty<string>(nameof(EventSeatCategory.Code));

    [TestMethod]
    public void EventIdTest() =>
        isProperty<Guid?>(nameof(EventSeatCategory.EventId));

    [TestMethod]
    public void SeatCategoryIdTest() =>
        isProperty<Guid?>(nameof(EventSeatCategory.SeatCategoryId));

    [TestMethod]
    public void EventTest() =>
        isProperty<Event>(nameof(EventSeatCategory.Event));

    [TestMethod]
    public void SeatCategoryTest() =>
        isProperty<SeatCategory>(nameof(EventSeatCategory.SeatCategory));

  
}
