using Abc.Aids;
using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Data
{
    public sealed class UserRole : BaseEntity
    {
        [Select(typeof(Person), nameof(Person.Email))]
        public Guid? PersonId { get; set; }

        public Person Person { get; set; }

        [Select(typeof(Role))]
        public Guid? RoleId { get; set; }

        public Role Role { get; set; }
    }
}
