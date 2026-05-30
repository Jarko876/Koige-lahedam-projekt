using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Data
{
    public class Creator : NamedEntity
    {
     
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        public ICollection<EventCreator> EventCreators { get; set; } = [];
    }
}
