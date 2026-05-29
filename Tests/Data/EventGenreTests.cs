using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public sealed class EventGenreTests : BaseTests<EventGenre>
{
    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(EventGenre.Id));
    [TestMethod] public void EventIdTest() => isProperty<Guid?>(nameof(EventGenre.EventId));
    [TestMethod] public void GenreIdTest() => isProperty<Guid?>(nameof(EventGenre.GenreId));
    [TestMethod] public void EventTest() => isProperty<Event>(nameof(EventGenre.Event));
    [TestMethod] public void GenreTest() => isProperty<Genre>(nameof(EventGenre.Genre));
}