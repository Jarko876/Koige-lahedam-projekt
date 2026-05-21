using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Data
{
    public class EventCreator
    {
        public int EventId { get; set; }

        public int CreatorId { get; set; }
        public Creator Creator { get; set; }
    }
}
