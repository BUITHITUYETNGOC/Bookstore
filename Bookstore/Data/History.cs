using System;
using System.Collections.Generic;

namespace Bookstore.Data;

public partial class History
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? OrderId { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Order? Order { get; set; }
}
