using System;
using System.Collections.Generic;
using System.Text;

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
    internal class Genre
    {
        public GenreType Type { get; set; }
    }
}
