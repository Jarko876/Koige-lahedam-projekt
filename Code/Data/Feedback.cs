using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Data
{
    public class Feedback : BaseEntity
    {
        
        public string Name { get; set; } = string.Empty;
        public string content { get; set; } = string.Empty;
    }
}
