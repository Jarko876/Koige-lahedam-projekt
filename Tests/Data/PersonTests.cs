using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public sealed class PersonTests : BaseTests<Person>
{
    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(Person.Id));
    [TestMethod] public void FirstNameTest() => isProperty<string>(nameof(Person.FirstName));
    [TestMethod] public void LastNameTest() => isProperty<string>(nameof(Person.LastName));
    [TestMethod] public void EmailTest() => isProperty<string>(nameof(Person.Email));
}