using Assignment3_Entity_FrameWork.Contexts;
using Assignment3_Entity_FrameWork.Entity.Inheritance_Mapping;
using Microsoft.EntityFrameworkCore;

namespace Assignment3_Entity_FrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterPriceDBContext DbContext = new EnterPriceDBContext();
            #region Inheritance Mapping


            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Salary = 5000,
            //    StartDate = DateTime.Now
            //};

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "Yasmin",
            //    Age = 25,
            //    CountOfHours = 30,
            //    HourRate = 300.30m

            //};

            //DbContext.Add(fullTimeEmployee);
            //DbContext.Add(partTimeEmployee);
            //DbContext.SaveChanges(); 
            #endregion

            //var Department = (from D in DbContext.Departmennts
            //                  where D.ID == 10
            //                  select D).FirstOrDefault();

            //Console.WriteLine($"{Department.ID} ::{Department.Name}");

            //foreach (var E in Department.Employees)
            //    Console.WriteLine(E.Name);

            //var Employee = (from E in DbContext.Employees
            //                where E.Id == 1
            //                select E).FirstOrDefault();

            //Console.WriteLine($"{Employee.Id} ::{Employee.Name}");

            //Console.WriteLine(Employee.Departmennt.Name);

            ///////////////////////////////////////////////////////////////

            // 1) BY Explicit Loading

            //DbContext.Entry(Department).Collection(D => D.Employees).Load();

            //foreach (var E in Department.Employees)
            //    Console.WriteLine(E.Name);

            //DbContext.Entry(Employee).Reference(E => E.Departmennt).Load();


            // 2) Egar Loading 

            //var Department = (from D in DbContext.Departmennts.Include(D=>D.Employees)
            //                  where D.ID == 10
            //                  select D).FirstOrDefault();

            //foreach (var E in Department.Employees)
            //    Console.WriteLine(E.Name);

            //var Employee = (from E in DbContext.Employees.Include(E=>E.Departmennt)
            //                where E.Id == 1
            //                select E).FirstOrDefault();

            //Console.WriteLine($"{Employee.Id} ::{Employee.Name}");

            //Console.WriteLine(Employee.Departmennt.Name);

            // 3) Lazy Loading
            //var Department = (from D in DbContext.Departmennts
            //                  where D.ID == 10
            //                  select D).FirstOrDefault();

            //foreach (var E in Department.Employees)
            //    Console.WriteLine(E.Name);

            //var Employee = (from E in DbContext.Employees
            //                where E.Id == 1
            //                select E).FirstOrDefault();

            //Console.WriteLine($"{Employee.Id} ::{Employee.Name}");

            //Console.WriteLine(Employee.Departmennt.Name);

        }
    }
}
