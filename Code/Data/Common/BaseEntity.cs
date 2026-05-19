using System.ComponentModel.DataAnnotations;

namespace Abc.Data.Common;

public abstract class BaseEntity {
    public virtual Guid Id { get; set; } = Guid.NewGuid();
    //[Timestamp] public virtual byte[] Timestamp { get; set; } = [];
}
