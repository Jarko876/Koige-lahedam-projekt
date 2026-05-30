using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public sealed class GenreTests : BaseTests<Genre>
{
    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(Genre.Id));
    [TestMethod] public void TypeTest() => isProperty<string>(nameof(Genre.Type));
}