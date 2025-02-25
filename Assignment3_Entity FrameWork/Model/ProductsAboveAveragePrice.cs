using System;
using System.Collections.Generic;

namespace Assignment3_Entity_FrameWork.Model
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
