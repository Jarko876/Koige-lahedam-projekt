using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Data
{
    public sealed class Role : NamedEntity
    {
        public ICollection<UserRole> UserRoles { get; set; } = [];
    }
}
