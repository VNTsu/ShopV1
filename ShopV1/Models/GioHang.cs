using System;
using System.Collections.Generic;

namespace ShopV1.Models
{

    public partial class GioHang
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string IdSanpham { get; set; }
        public byte? SoLuong { get; set; }
    }
}
