using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment3_Entity_FrameWork.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }


        public ICollection<Student_Course> CourseStudent { get; set; } = new HashSet<Student_Course>();
    }
}
