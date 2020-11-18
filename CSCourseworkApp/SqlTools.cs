using System;
using System.Data.SqlClient;
using System.Diagnostics;

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
            try
            {
                return command.ExecuteReader();
            } catch(Exception ex)
            {
                Debug.WriteLine("Could not execute reader! {0}", ex);
                return null;
            }
        }

        public int executeScalar(string query)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                try
                {
                    return (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Could not execute reader! {0}", ex);
                    return 0;
                }
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
            try
            {
                connection.Close();
                connection.Dispose();
            } catch (Exception e)
            {
                Debug.WriteLine(e);
            }

        }
    }
}
