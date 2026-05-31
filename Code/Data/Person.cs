using Abc.Data.Common;

namespace Abc.Data {
    public sealed class Person : BaseEntity {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
