using Abc.Data.Common;

namespace Abc.Data {
    public sealed class Role : NamedEntity {
        public ICollection<UserRole> UserRoles { get; set; } = [];
        public ICollection<Person> People => [.. (UserRoles ?? []).Select(c => c.Person)];
    }
}
