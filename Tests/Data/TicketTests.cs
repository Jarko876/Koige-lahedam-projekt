using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public class TicketTests: BaseTests<Ticket>
{
    [TestMethod] public void PersonIdTest() => isProperty<int>(nameof(Ticket.PersonId));

    [TestMethod] public void FinalPriceTest() => isProperty<decimal>(nameof(Ticket.FinalPrice));
}
