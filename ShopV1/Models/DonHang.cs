using System;
using System.Collections.Generic;

namespace ShopV1.Models
{
    public partial class DonHang
    {
        public int Id { get; set; }
        public string MaDonhang { get; set; }
        public string TenKhachhang { get; set; }
        public int IdUser { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public string Ghichu { get; set; }
        public double? Tongtien { get; set; }
        public bool? Stats { get; set; }
    }
}
