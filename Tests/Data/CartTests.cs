using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public class CartTests : BaseTests<Cart> {
    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(Cart.Id));
    [TestMethod] public void NameTest() => isProperty<string>(nameof(Cart.Name));

    [TestMethod] public void CodeTest() => isProperty<string>(nameof(Cart.Code));

    [TestMethod] public void PersonIdTest() => isProperty<Guid>(nameof(Cart.PersonId));

    [TestMethod] public void CreatedAtTest() => isProperty<DateTime>(nameof(Cart.CreatedAt));

    [TestMethod] public void PersonTest() =>
    isProperty<Person>(nameof(Cart.Person));

    [TestMethod] public void TicketsTest() =>
    isProperty<ICollection<Ticket>>(nameof(Cart.Tickets));

    [TestMethod] public void PaymentsTest() =>
    isProperty<ICollection<Payment>>(nameof(Cart.Payments));
}
