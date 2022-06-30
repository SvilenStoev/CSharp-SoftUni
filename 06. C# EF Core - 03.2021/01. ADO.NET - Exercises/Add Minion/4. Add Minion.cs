using Microsoft.Data.SqlClient;
using System;
using System.Linq;

namespace Add_Minion
{
    class Program
    {
        static void Main(string[] args)
        {
            var minionInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var villainInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string minionName = minionInfo[1];
            int minionAge = int.Parse(minionInfo[2]);
            string minionTown = minionInfo[3];

            string villainName = villainInfo[1];

            using var connection = new SqlConnection("Server=.;Integrated Security=true;Database=MinionsDB");

            connection.Open();

            SqlCommand townIdSelectCommand = InsertTown(minionTown, connection);
            int townId = (int)townIdSelectCommand.ExecuteScalar();

            SqlCommand villainIdSelectCommand = InsertVillain(villainName, connection);
            int villainId = (int)villainIdSelectCommand.ExecuteScalar();

            SqlCommand minionSelectCommand = InsertMinion(minionName, connection, townId, minionAge);
            int minionId = (int)minionSelectCommand.ExecuteScalar();

            SqlCommand setMinionServentOfTheVillain = new SqlCommand(
                $"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES ({minionId}, {villainId})", connection);

            setMinionServentOfTheVillain.ExecuteNonQuery();

            Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");


            //Transaction in C# and SQL:

            using SqlTransaction sqlTransaction = connection.BeginTransaction();

            townIdSelectCommand.Transaction = sqlTransaction;

            sqlTransaction.Commit();

            try
            {
                   //Code..
            }
            catch (Exception ex)
            {
                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    Console.WriteLine(rollbackEx);
                }
            }
        }

        private static SqlCommand InsertVillain(string villainName, SqlConnection connection)
        {
            var villainSelectCommand = new SqlCommand(@"SELECT Id FROM Villains WHERE Name = @villainName", connection);

            villainSelectCommand.Parameters.AddWithValue("@villainName", villainName);

            if (villainSelectCommand.ExecuteScalar() == null)
            {
                var villainInsertCommand = new SqlCommand($"INSERT INTO Villains (Name, EvilnessFactorId) VALUES (@villainToAdd, 4) ", connection);

                villainInsertCommand.Parameters.AddWithValue("@villainToAdd", villainName);

                villainInsertCommand.ExecuteNonQuery();

                Console.WriteLine($"Villain {villainName} was added to the database.");
            }

            return villainSelectCommand;
        }

        private static SqlCommand InsertTown(string minionTown, SqlConnection connection)
        {
            var townSelectCommand = new SqlCommand(
                @"SELECT Id FROM Towns WHERE Name = @minionTown", connection);

            townSelectCommand.Parameters.AddWithValue("@minionTown", minionTown);

            if (townSelectCommand.ExecuteScalar() == null)
            {
                var townInsertCommand = new SqlCommand($"INSERT INTO Towns (Name, CountryCode) VALUES (@minionTownToAdd, 1) ", connection);

                townInsertCommand.Parameters.AddWithValue("@minionTownToAdd", minionTown);

                townInsertCommand.ExecuteNonQuery();

                Console.WriteLine($"Town {minionTown} was added to the database.");
            }

            return townSelectCommand;
        }

        private static SqlCommand InsertMinion(string minionName, SqlConnection connection, int townId, int minionAge)
        {
            var minionSelectCommand = new SqlCommand(
                @"SELECT Id FROM Minions WHERE Name = @minionName", connection);

            minionSelectCommand.Parameters.AddWithValue("@minionName", minionName);

            if (minionSelectCommand.ExecuteScalar() == null)
            {
                var minionInsertCommand = new SqlCommand($"INSERT INTO Minions (Name, Age, TownId) VALUES (@minionToAdd, @Age, {townId}) ", connection);

                minionInsertCommand.Parameters.AddWithValue("@minionToAdd", minionName);
                minionInsertCommand.Parameters.AddWithValue("@Age", minionAge);

                minionInsertCommand.ExecuteNonQuery();
            }

            return minionSelectCommand;
        }
    }
}
