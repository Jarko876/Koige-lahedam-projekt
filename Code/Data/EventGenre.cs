using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using Abc.Aids;
using Abc.Data.Common;

namespace Abc.Data
{
    public class EventGenre : NamedEntity
    {
        [Select(typeof(Event))] public Guid? EventId { get; set; }
        [Select(typeof(Genre))] public Guid? GenreId { get; set; }
        public Event Event { get; set; }
        public Genre Genre { get; set; }
    }
}
