using Abc.Aids;
using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Data
{
    public class Feedback : NamedEntity
    {
        
        public string Name { get; set; } = string.Empty;
        public string content { get; set; } = string.Empty;

        [Select(typeof(EventObject))]
        public Guid? EventObjectId { get; set; }
        public EventObject? EventObject { get; set; }
    }
}
