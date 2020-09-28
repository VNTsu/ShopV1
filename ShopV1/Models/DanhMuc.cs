using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopV1.Models
{
    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        public int Id { get; set; }
        public int? IdParent { get; set; }
        public string Ten { get; set; }
        
    }
}
