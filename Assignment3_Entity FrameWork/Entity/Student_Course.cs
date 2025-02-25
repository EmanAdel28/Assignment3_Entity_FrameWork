using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Entity_FrameWork.Entity
{
    public class Student_Course
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
