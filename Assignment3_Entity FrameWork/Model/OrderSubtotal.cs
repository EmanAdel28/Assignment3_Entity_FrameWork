using System;
using System.Collections.Generic;

namespace Assignment3_Entity_FrameWork.Model
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
