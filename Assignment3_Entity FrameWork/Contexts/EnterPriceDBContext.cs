using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3_Entity_FrameWork.Entity;
using Microsoft.EntityFrameworkCore;

namespace Assignment3_Entity_FrameWork.Contexts
{
    public class EnterPriceDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITI.; Trusted_Connection = true ;TrustServerCertificate =true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>()
                .HasKey(SC=>new {SC.StudentId,SC.CourseId});
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Student_Course> Students_Course { get; set; }
    }
}
