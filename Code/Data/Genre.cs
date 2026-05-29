using System.ComponentModel.DataAnnotations;
using Abc.Data.Common;

namespace Abc.Data
{
    public class Genre : NamedEntity
    {
        [Required]
        public string Type { get; set; } = "";
    }
}
