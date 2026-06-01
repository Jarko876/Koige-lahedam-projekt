using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public class TicketTests: BaseTests<Ticket>
{
    [TestMethod] public void PersonIdTest() => isProperty<Guid?>(nameof(Ticket.PersonId));

    [TestMethod] public void FinalPriceTest() => isProperty<decimal>(nameof(Ticket.FinalPrice));

    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(Ticket.Id));

    [TestMethod] public void DetailsTest() => isProperty<string>(nameof(Ticket.Details));

    [TestMethod] public void NameTest() => isProperty<string>(nameof(Ticket.Name));

    [TestMethod] public void CodeTest() => isProperty<string>(nameof(Ticket.Code));

    [TestMethod] public void SeatIdTest() => isProperty<Guid?>(nameof(Ticket.SeatId));

    [TestMethod] public void CartIdTest() => isProperty<Guid?>(nameof(Ticket.CartId));

    [TestMethod] public void EventObjectIdTest() => isProperty<Guid?>(nameof(Ticket.EventObjectId));

    [TestMethod]
    public void SeatTest() =>
    isProperty<Seat>(nameof(Ticket.Seat));

    [TestMethod]
    public void PersonTest() =>
    isProperty<Person>(nameof(Ticket.Person));

    [TestMethod]
    public void CartTest() =>
    isProperty<Cart>(nameof(Ticket.Cart));


    [TestMethod]
    public void EventObjectTest() =>
    isProperty<EventObject>(nameof(Ticket.EventObject));

}
