using System;
using System.Collections.Generic;

namespace Bookstore.Data;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Address { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
