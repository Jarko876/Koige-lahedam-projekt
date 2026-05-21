using System;
using System.Collections.Generic;
using System.Text;
using Abc.Data.Common;

namespace Abc.Data
{
    public enum GenreType
    {
        Action,
        Comedy,
        Drama,
        Horror,
        ScienceFiction,
        Romance,
        Thriller,
        Fantasy,
        Animation,
        Documentary
    }
    public class Genre : NamedEntity
    {
        public GenreType Type { get; set; }
    }
}
