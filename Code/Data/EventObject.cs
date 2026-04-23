using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
    public class EventObject
    {
        public EventType Type { get; set; }
        public AgeRating Rating { get; set; }
        [Required] public string OriginalLanguage { get; set; } = "";
        [Range(1, 1000)] public int DurationMinutes { get; set; }
        [Required] public string Description { get; set; } = "";
        public DateTime ReleaseDate { get; set; }

    }
}
