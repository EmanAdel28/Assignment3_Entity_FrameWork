using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3_Entity_FrameWork.Entity;
using Assignment3_Entity_FrameWork.Entity.Inheritance_Mapping;
using Microsoft.EntityFrameworkCore;

namespace Assignment3_Entity_FrameWork.Contexts
{
    public class EnterPriceDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = . ; Database = ITI.; Trusted_Connection = true ;TrustServerCertificate =true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>()
                .HasKey(SC=>new {SC.StudentId,SC.CourseId});

            //modelBuilder.Entity<FullTimeEmployee>()
            //            .HasBaseType<Employee>()
            //            .Property(F => F.Salary)
            //            .HasColumnName("decimal(10,3)");

            //modelBuilder.Entity<PartTimeEmployee>()
            //            .HasBaseType<Employee>()
            //            .Property(P => P.HourRate)
            //            .HasColumnName("decimal(5,2)");

            modelBuilder.Entity<EmployeeDepartmentView>()
                        .ToView("EmployeeDepartmentViews")
                        .HasNoKey();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Student_Course> Students_Course { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departmennt> Departmennts { get; set; }

        public DbSet<EmployeeDepartmentView> EmployeeDepartmentViews { get; set; }

        // Table Per Concrete Class 

        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<FullTimeEmployee> PartTimeEmployees { get; set; }

        // Table Per Hirarchy

        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<FullTimeEmployee> PartTimeEmployees { get; set; }

    }
}
