using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.viewModel
{
    public class DanhMucViewModel
    {

        public int Id { get; set; }

        public int? IdParent { get; set; }

        public string Ten { get; set; }
    }
}
