using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Data;

public partial class Customer
{
    [Display(Name="Mã khách hàng")]
    public int Id { get; set; }
    
    [Display(Name = "Họ tên")]
    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    [Display(Name = "Số điện thoại")]
    public string Phone { get; set; } = null!;

    [Display(Name = "Địa chỉ nhận hàng")]
    public string? Address { get; set; }

    [Display(Name = "Ngày sinh")]
    public DateOnly? BirthDay { get; set; }

    [Display(Name = "Giới tính")]
    public string? Gender { get; set; }

    [Display(Name = "Loại tài khoản")]
    public int? AccountId { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
