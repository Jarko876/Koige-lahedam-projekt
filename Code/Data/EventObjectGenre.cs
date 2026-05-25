using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using Abc.Aids;
using Abc.Data.Common;

namespace Abc.Data
{
    public class EventObjectGenre : NamedEntity
    {
        [Select(typeof(EventObject))] public Guid? EventObjectId { get; set; }
        [Select(typeof(Genre))] public Guid? GenreId { get; set; }
        public EventObject EventObject { get; set; }
        public Genre Genre { get; set; }
    }
}
