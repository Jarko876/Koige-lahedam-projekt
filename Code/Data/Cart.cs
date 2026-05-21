using System;
using System.Collections.Generic;
using Abc.Data.Common;

namespace Abc.Data;

public class Cart : NamedEntity {
    
    public int PersonId { get; set; }
    //public Person Person { get; set; } - hiljem lisada?
    public DateTime CreatedAt { get; set; }
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>(); //üks ostukorv võib sisaldada mitut piletit

}
