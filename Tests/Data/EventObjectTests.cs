using Abc.Data;
using Abc.Tests.Aids;

namespace Abc.Tests.Data;

[TestClass]
public sealed class EventObjectTests : BaseTests<EventObject>
{
    [TestMethod] public void IdTest() => isProperty<Guid>(nameof(EventObject.Id));
    [TestMethod] public void TypeTest() => isProperty<string>(nameof(EventObject.Type));
    [TestMethod] public void RatingTest() => isProperty<string>(nameof(EventObject.Rating));
    [TestMethod] public void OriginalLanguageTest() => isProperty<string>(nameof(EventObject.OriginalLanguage));
    [TestMethod] public void DescriptionTest() => isProperty<string>(nameof(EventObject.Description));
    [TestMethod] public void ReleaseDateTest() => isProperty<DateTime>(nameof(EventObject.ReleaseDate));
    [TestMethod] public void HallIdTest() => isProperty<Guid?>(nameof(EventObject.HallId));
    [TestMethod] public void HallTest() => isProperty<Hall?>(nameof(EventObject.Hall));
    [TestMethod] public void EventIdTest() => isProperty<Guid?>(nameof(EventObject.EventId));
    [TestMethod] public void EventTest() => isProperty<Event?>(nameof(EventObject.Event));
}