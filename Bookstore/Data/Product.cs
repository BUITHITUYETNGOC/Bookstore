using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Data;

public partial class Product
{
    [Display(Name = "Mã sách")]
    public int Id { get; set; }

    [Display(Name = "Tên sách")]
    public string Name { get; set; } = null!;

    [Display(Name = "Mô tả")]
    public string? Description { get; set; }

    [Display(Name = "Giá bán")]
    public decimal UnitPrice { get; set; }

    [Display(Name = "Số lượng")]
    public int Quantity { get; set; }

    [Display(Name = "Mã loại")]
    public int? CategoryId { get; set; }

    [Display(Name = "Mã nhà cung cấp")]
    public int? SupplierId { get; set; }

    [Display(Name = "Ngày cập nhật")]
    public DateTime? UpdateLast { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Supplier? Supplier { get; set; }
}
