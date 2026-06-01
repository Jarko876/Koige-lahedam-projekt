using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public class SeatTests: BaseTests<Seat>
{
    [TestMethod] public void NumberTest() => isProperty<int>(nameof(Seat.Number));
    [TestMethod] public void RowTest() => isProperty<int>(nameof(Seat.Row));

    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(Seat.Id));

    [TestMethod] public void DetailsTest() => isProperty<string>(nameof(Seat.Details));

    [TestMethod] public void NameTest() => isProperty<string>(nameof(Seat.Name));

    [TestMethod] public void CodeTest() => isProperty<string>(nameof(Seat.Code));

    [TestMethod] public void HallIdTest() => isProperty<Guid?>(nameof(Seat.HallId));

    [TestMethod] public void HallTest() => isProperty<Hall>(nameof(Seat.Hall));

    [TestMethod]
    public void SeatCategoryIdTest() =>
        isProperty<Guid?>(nameof(Seat.SeatCategoryId));

    [TestMethod]
    public void SeatCategoryTest() =>
        isProperty<SeatCategory>(nameof(Seat.SeatCategory));

}
