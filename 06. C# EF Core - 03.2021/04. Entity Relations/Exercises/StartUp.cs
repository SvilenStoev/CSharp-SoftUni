using Exercises.Models;
using System;
using System.Linq;

namespace Exercises
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var departmentAcc = new Department { Name = "Accounting" };
            var departmentHr = new Department { Name = "HR" };

            for (int i = 150; i < 500; i += 100)
            {
                db.Employees.Add(new Employee
                {
                    FirstName = "Svilen" + i,
                    LastName = "Stoev",
                    StartWorkDate = DateTime.UtcNow,
                    Salary = 2300 + i,

                    Department = departmentAcc
                });
            }

            for (int i = 150; i < 500; i += 100)
            {
                db.Employees.Add(new Employee
                {
                    FirstName = "Tedi" + i,
                    LastName = "Savov",
                    StartWorkDate = DateTime.UtcNow,
                    Salary = 1300 + i,

                    Department = departmentHr
                });
            }

            db.SaveChanges();
        }
    }
}
