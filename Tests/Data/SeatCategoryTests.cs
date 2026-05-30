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

}
