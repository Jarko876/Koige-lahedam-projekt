using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Data
{
    internal class Creator
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        public ICollection<EventCreator> EventCreators { get; set; } = new List<EventCreator>();
    }
}
