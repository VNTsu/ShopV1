using System;
using System.Collections.Generic;

namespace ShopV1.Models
{
    public partial class AdminAccount
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
