using Abc.Data.Common;
using System.ComponentModel;

namespace Abc.Data;

public sealed class HallCategory : NamedEntity {
    [DisplayName("Title")] public override string Name { get; set; }

    //public ICollection<Hall> Halls { get; set; } = [];
}
