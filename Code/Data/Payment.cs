using System;
using System.Collections.Generic;
using System.Text;
using Abc.Data.Common;

namespace Abc.Data;

public class Payment : BaseEntity {
    public Guid CartId { get; set; }
    public Cart Cart { get; set; }
    public decimal Amount { get; set; }
    public string PaymentStatus { get; set; } //pending v paid
    public DateTime PaymentDate { get; set; }

}
