using Abc.Aids;
using Abc.Data.Common;
using System.ComponentModel.DataAnnotations;


namespace Abc.Data
{
    public class EventObject : NamedEntity
    {
        [Required] public string Type { get; set; } = "";

        [Required] public string Rating { get; set; } = "";

        [Required] public string OriginalLanguage { get; set; } = "";

        [Required] public string Description { get; set; } = "";

        public DateTime ReleaseDate { get; set; }

        [Select(typeof(Hall))] public Guid? HallId { get; set; }

        public Hall? Hall { get; set; }

        [Select(typeof(Event))] public Guid? EventId { get; set; }

        public Event? Event { get; set; }
    
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
