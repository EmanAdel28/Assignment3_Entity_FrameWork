using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Entity_FrameWork.Entity.Inheritance_Mapping
{
    public class Departmennt
    {
        public int ID { get; set; }
        public string Name { get; set; }

       public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
