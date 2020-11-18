using System;
using System.Data.SqlClient;

namespace CSCourseworkApp
{
    class SqlTools : IDisposable
    {
        static private SqlConnection connection;
        static private SqlCommand command;
        public SqlDataReader reader;
        public static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CSDb.mdf;Integrated Security = True";
        public SqlDataReader executeReader(string query)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand(query, connection);
            return command.ExecuteReader();
        }
        public int executeScalar(string query)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }
        public int getRows(string table)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand("SELECT COUNT(*) FROM " + table, connection);
                return (int)command.ExecuteScalar();
            }
        }

        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
