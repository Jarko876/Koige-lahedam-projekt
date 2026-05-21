using Abc.Aids;
using Abc.Data.Common;
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
    public class EventObject : NamedEntity {
        public EventType Type { get; set; }
        public AgeRating Rating { get; set; }
        [Required] public string OriginalLanguage { get; set; } = "";
        [Range(1, 1000)] public int DurationMinutes { get; set; }
        [Required] public string Description { get; set; } = "";
        public DateTime ReleaseDate { get; set; }
        public ICollection<EventObjectGenre> EventObjectGenres { get; set; } = [];
        public ICollection<Genre> Genres => [.. EventObjectGenres.Select(c => c.Genre)];
        [Select(typeof(Hall))] public Guid HallId { get; set; }
        public Hall Hall { get; set; }
        [Select(typeof(Event))] public Guid EventId { get; set; }
        public Event Event { get; set; }

    }
}
