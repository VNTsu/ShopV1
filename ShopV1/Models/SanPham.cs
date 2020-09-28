using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopV1.Models
{
    public partial class SanPham
    {
        public int Id { get; set; }
        public string MaSanphan { get; set; }
        public string TenSanpham { get; set; }
        public string AnhSanpham { get; set; }
        public string Mau { get; set; }
        public string Size { get; set; }
        public string Mota { get; set; }
        public double? GiaSanpham { get; set; }
        public double? GiaKm { get; set; }
        public int? IdDanhmuc { get; set; }
        public int? SoLuong { get; set; }
        public bool? Status { get; set; }
        public enum Color
        {
            Xanh, Đỏ ,Tím , Vàng
        }
        [NotMapped]
        public List<DanhMuc> dm { get; set; }
    }
}
