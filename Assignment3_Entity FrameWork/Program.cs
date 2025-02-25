using Assignment3_Entity_FrameWork.Contexts;
using Assignment3_Entity_FrameWork.Entity.Inheritance_Mapping;

namespace Assignment3_Entity_FrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterPriceDBContext DbContext = new EnterPriceDBContext();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Ahmed",
                Age = 30,
                Salary = 5000,
                StartDate = DateTime.Now
            };

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "Yasmin",
                Age = 25,
                CountOfHours = 30,
                HourRate=300.30m
             
            };

            DbContext.Add(fullTimeEmployee);
            DbContext.Add(partTimeEmployee);
            DbContext.SaveChanges();
        }
    }
}
