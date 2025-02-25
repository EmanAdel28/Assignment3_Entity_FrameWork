using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Entity_FrameWork.Entity.Inheritance_Mapping
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }

        [ForeignKey("Departmennt")]
        public int DeptId { get; set; }
        public virtual Departmennt Departmennt { get; set; }
    }
}
