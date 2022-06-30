using System;
using Microsoft.Data.SqlClient;

namespace Villain_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            using var connection = new SqlConnection("Server=.;Integrated Security=true;Database=MinionsDB");

            connection.Open();

            var sqlCommand = new SqlCommand(
                @"SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount FROM Villains v
                    JOIN MinionsVillains mv ON v.Id = mv.VillainId
                    GROUP BY v.Name
                    HAVING COUNT(mv.VillainId) > 3
                    ORDER BY COUNT(mv.VillainId) DESC", connection);

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    Console.WriteLine($"{sqlDataReader["Name"]} - {sqlDataReader["MinionsCount"]}");
                }
            }
        }
    }
}
