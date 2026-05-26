using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abc.Data.Common;

namespace Abc.Data
{
    public class Genre : NamedEntity
    {
        [Required]
        public string Type { get; set; } = "";
    }
}
