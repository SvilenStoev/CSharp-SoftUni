using Exercises.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SoftUniContext();

            var employees = db.Employees
                .Where(x => x.FirstName.StartsWith("S"))
                .OrderByDescending(x => x.Salary);

            Console.WriteLine(employees.ToQueryString());

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} -> {employee.Salary} ");
            }

            List<List<string>> list = new List<List<string>>
            {
                new List<string> { "Gosho", "Pesho"},
                new List<string> { "Drug Pesho", "Drug Gosho"},
            };

            List<string> selectMany = list.SelectMany(x => x).ToList();

            selectMany.ForEach(x => Console.WriteLine(x));

        }
    }
}
