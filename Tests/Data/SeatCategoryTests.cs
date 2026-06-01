using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public class SeatCategoryTests : BaseTests<SeatCategory>
{
    [TestMethod] public void EventSeatCategoryIsNotEmptyTest()
    {
        var seatCategory = new SeatCategory();

        Assert.IsEmpty(seatCategory.EventSeatCategories); 
            
    }

    [TestMethod] public void EventSeatCategoryIsNotNullTest()
    {
        var seatCategory = new SeatCategory();

        Assert.IsNotNull(seatCategory.EventSeatCategories);
    }

    [TestMethod]
    public void EventsTest() =>
    Assert.IsNotNull(obj.Events);

    [TestMethod]
    public void EventSeatCategoriesTest() =>
    isProperty<ICollection<EventSeatCategory>>(nameof(SeatCategory.EventSeatCategories));

    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(SeatCategory.Id));

    [TestMethod] public void DetailsTest() => isProperty<string>(nameof(SeatCategory.Details));

    [TestMethod] public void NameTest() => isProperty<string>(nameof(SeatCategory.Name));

    [TestMethod] public void CodeTest() => isProperty<string>(nameof(SeatCategory.Code));

}
