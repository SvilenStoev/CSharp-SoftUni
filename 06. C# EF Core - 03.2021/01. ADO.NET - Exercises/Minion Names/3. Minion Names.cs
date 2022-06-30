using Microsoft.Data.SqlClient;
using System;

namespace Minion_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter Villain Id: ");
            string villainId = Console.ReadLine();

            using (var connection = new SqlConnection("Server=.;Integrated Security=true;Database=MinionsDB"))
            {
                connection.Open();

                var sqlCommandGetVillianName = new SqlCommand(
                   @$"SELECT Name FROM Villains WHERE id = @villainId", connection);

                sqlCommandGetVillianName.Parameters.AddWithValue("@villainId", villainId);

                string villianName = sqlCommandGetVillianName.ExecuteScalar()?.ToString();

                if (villianName == null)
                {
                    Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                }
                else
                {
                    var sqlCommand = new SqlCommand(
                        @$"SELECT v.Name, m.Name AS MinionName, m.Age FROM Villains v
                    JOIN MinionsVillains mv ON mv.VillainId = v.Id
                    JOIN Minions m ON m.Id = mv.MinionId
                    Where v.Id = @villainId
                    ORDER BY m.Name", connection);

                    sqlCommand.Parameters.AddWithValue("@villainId", villainId);

                    using (var sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            Console.WriteLine($"Villain: {villianName}");

                            int i = 1;

                            while (sqlDataReader.Read())
                            {
                                Console.WriteLine($"{i++}. {sqlDataReader["MinionName"]} {sqlDataReader["Age"]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Villain: {villianName}");
                            Console.WriteLine("(no minions)");
                        }
                    }
                }
            }
        }
    }
}
