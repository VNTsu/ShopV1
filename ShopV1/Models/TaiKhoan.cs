using System;
using System.Collections.Generic;

namespace ShopV1.Models
{
    public partial class TaiKhoan
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Matkhau { get; set; }
        public string TenKhachhang { get; set; }
        public string Gioitinh { get; set; }
        public string Diachi { get; set; }
        public string Phone { get; set; }
        public DateTime? Ngaysinh { get; set; }
    }
}
