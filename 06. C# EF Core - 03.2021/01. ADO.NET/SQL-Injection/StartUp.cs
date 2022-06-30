using System;
using Microsoft.Data.SqlClient;

namespace SQL_Injection
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("UserName: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            using (var connection = new SqlConnection(
                "Server=.;Integrated Security=true; Database=Bitbucket"))
            {
                connection.Open();

                var sqlCommand = new SqlCommand(
                    $"SELECT COUNT(*) FROM Users WHERE Username = '@Username' AND Password = '@Password'", connection);

                int usersCount = (int)sqlCommand.ExecuteScalar();

                sqlCommand.Parameters.Add(new SqlParameter("@Username", username));
                sqlCommand.Parameters.Add(new SqlParameter("@Password", password));


                if (usersCount > 0)
                {
                    Console.WriteLine($"Welcome {username}!");
                }
                else
                {
                    Console.WriteLine("Wrong username or password!");
                }
            }
        }
    }
}
