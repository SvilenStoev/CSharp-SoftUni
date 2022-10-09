namespace demo
{
    using Microsoft.Data.SqlClient;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(
                "Server=.;Integrated Security=true;Database=SoftUni"))
            {
                connection.Open();

                string query = "SELECT * FROM Employees";

                var sqlCommand = new SqlCommand(query, connection);

                Console.WriteLine(sqlCommand.ExecuteScalar());
            };

      


        }
    }
}
