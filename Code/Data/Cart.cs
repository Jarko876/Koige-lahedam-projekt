using System;
using System.Collections.Generic;
using Abc.Data.Common;

namespace Abc.Data;

public class Cart : NamedEntity {

    public Guid? PersonId { get; set; }
    public Person Person { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>(); //üks ostukorv võib sisaldada mitut piletit
    public ICollection<Payment> Payments { get; set; } = new List<Payment>(); //üks ostukorv võib sisaldada mitut maksemetoodust

}
