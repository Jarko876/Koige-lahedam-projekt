using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Data
{
    public sealed class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
