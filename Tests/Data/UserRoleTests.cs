using Abc.Aids;
using Abc.Data;
using Abc.Tests.Aids;
using System.Reflection;

namespace Abc.Tests.Data;

[TestClass]
public sealed class UserRoleTests : BaseTests<UserRole>
{
    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(UserRole.Id));
    [TestMethod] public void PersonIdTest() => isProperty<Guid?>(nameof(UserRole.PersonId));
    [TestMethod] public void PersonTest() => isProperty<Person>(nameof(UserRole.Person));
    [TestMethod] public void RoleIdTest() => isProperty<Guid?>(nameof(UserRole.RoleId));
    [TestMethod] public void RoleTest() => isProperty<Role>(nameof(UserRole.Role));

    [TestMethod]
    public void PersonIdSelectAttributeTest()
    {
        var property = typeof(UserRole).GetProperty(nameof(UserRole.PersonId));
        var attribute = property?.GetCustomAttribute<SelectAttribute>();

        Assert.IsNotNull(attribute);
        Assert.AreEqual(typeof(Person), attribute.EntityType);
        Assert.AreEqual(nameof(Person.Email), attribute.DisplayProperty);
    }

    [TestMethod]
    public void RoleIdSelectAttributeTest()
    {
        var property = typeof(UserRole).GetProperty(nameof(UserRole.RoleId));
        var attribute = property?.GetCustomAttribute<SelectAttribute>();

        Assert.IsNotNull(attribute);
        Assert.AreEqual(typeof(Role), attribute.EntityType);
    }
}