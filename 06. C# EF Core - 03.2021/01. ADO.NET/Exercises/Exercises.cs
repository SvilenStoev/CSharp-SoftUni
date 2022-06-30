using MyClasses;
using System;
using Belot.Engine;
using Microsoft.Data.SqlClient;

namespace Exercises
{
    class Exercises
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(
                "Server=.;Integrated Security=true;Database = SoftUni"))
            {
                connection.Open();

                var sqlCommand = new SqlCommand(
                    "SELECT d.Name, COUNT(*) AS Count " +
                    "FROM Employees e " +
                    "JOIN Departments d " +
                    "ON d.DepartmentId = e.DepartmentId " +
                    "GROUP BY d.Name ", connection);
                using (SqlDataReader sqlDateReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDateReader.Read())
                    {
                        Console.WriteLine($"{sqlDateReader["Name"]} => {sqlDateReader["Count"]}");
                    }
                }
            }
        }
    }
}
