using System;
using System.Collections.Generic;

namespace Bookstore.Data;

public partial class Order
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
