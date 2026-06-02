using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public class PaymentTests : BaseTests<Payment>
{
    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(Payment.Id));
    [TestMethod] public void NameTest() => isProperty<string>(nameof(Payment.Name));
    [TestMethod] public void CodeTest() => isProperty<string>(nameof(Payment.Code));
    [TestMethod] public void CartIdTest() => isProperty<Guid?>(nameof(Payment.CartId));
    [TestMethod] public void AmountTest() => isProperty<decimal>(nameof(Payment.Amount));
    [TestMethod] public void PaymentStatusTest() => isProperty<string>(nameof(Payment.PaymentStatus));
    [TestMethod] public void PaymentDateTest() => isProperty<DateTime>(nameof(Payment.PaymentDate));
    [TestMethod] public void CartTest() => isProperty<Cart>(nameof(Payment.Cart));
}
