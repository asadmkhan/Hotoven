using System;
using System.Collections.Generic;

namespace HotOven.Models
{
    public partial class Products
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
