using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Entity_FrameWork.Entity.Inheritance_Mapping
{
    public class PartTimeEmployee:Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }
    }
}
