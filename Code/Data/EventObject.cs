using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abc.Data.Common;

namespace Abc.Data
{
    public enum EventType
    {
        Film,
        Etendus
    }
    public enum AgeRating
    {
        G,
        PG,
        PG13,
        R,
        NC17
    }
    public class EventObject : BaseEntity
    {
        public EventType Type { get; set; }
        public AgeRating Rating { get; set; }
        [Required] public string OriginalLanguage { get; set; } = "";
        [Range(1, 1000)] public int DurationMinutes { get; set; }
        [Required] public string Description { get; set; } = "";
        public DateTime ReleaseDate { get; set; }

    }
}
