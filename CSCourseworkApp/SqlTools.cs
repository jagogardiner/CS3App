using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CSCourseworkApp
{
    class SqlTools : IDisposable
    {
        /*
         * SqlTools (class)
         * Wrapper-type class around different System.Data.SqlClient
         * methods used within the entirety of the program
         * to make SQL queries easier.
         */

        // Private connection and command that we can reuse
        static private SqlConnection connection;
        private static readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CSDb.mdf;Integrated Security = True";
        // Make reader public for executeReader usage.
        public SqlDataReader reader;

        private SqlDataReader ExecuteReader(SqlCommand command)
        {
            /*
             * executeReader returns an SqlDataReader to read
             * from data based on the query string provided.
             * 
             * Arguments: 
             * command (SqlCommand): SQL command query object
            */
            connection = new SqlConnection(connectionString);
            connection.Open();
            command.Connection = connection;
            /* Note that try catch isn't attempted
             * SqlCommand has its own valid exceptions
             * and catches should be used in local scope instead
             */
            return command.ExecuteReader();
        }

        public static int ExecuteScalar(SqlCommand command)
        {
            /*
             * executeScalar returns an integer-casted scalar
             * to read integer values from a query instead of
             * creating a new reader object.
             * 
             * Arguments:
             * command (SqlCommand): SQL command query object
             */
            using (SqlTools t = new SqlTools())
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    command.Connection = connection;
                    // Make sure we cast int on scalar
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public static DataTable GetTable(SqlCommand command)
        {
            DataTable dt = new DataTable();
            using (SqlTools t = new SqlTools())
            {
                t.reader = t.ExecuteReader(command);
                dt.Load(t.reader);
                return dt;
            }
        }

        public static DataTable GetTable(string query)
        {
            SqlCommand sql = new SqlCommand(query);
            return GetTable(sql);
        }

        public static void ExecuteNonQuery(SqlCommand comm)
        {
            /*
             * ExecuteNonQuery just does the same as SqlCommand's
             * normal ExecuteNonQuery but using this method, we
             * don't need to worry about opening and closing connections.
             */
            using (SqlTools t = new SqlTools())
            {
                using (connection = new SqlConnection(connectionString))
                {
                    comm.Connection = connection;
                    connection.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }

        public static void ExecuteNonQuery(string query)
        {
            SqlCommand comm = new SqlCommand(query);
            ExecuteNonQuery(comm);
        }

        public static void UpdateDatabaseFromTable(SqlCommand command, DataTable dt)
        {
            // Generates an update command based off the previous data in the database
            // provided in the command, and the new data in the datatable, dt.
            using (SqlTools t = new SqlTools())
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    command.Connection = connection;
                    SqlDataAdapter sqlDa = new SqlDataAdapter();
                    sqlDa.SelectCommand = command;
                    SqlCommandBuilder cb = new SqlCommandBuilder(sqlDa);
                    sqlDa.Fill(dt);
                    sqlDa.UpdateCommand = cb.GetUpdateCommand();
                    sqlDa.Update(dt);
                }
            }
        }

        public void Dispose()
        {
            /*
             * Dispose is called each time at the end of a using()
             * statement. It is a clean way to close and dispose a
             * connection without needing to code disposing the
             * connection each time.
             * 
             * Since SqlTools is an IDisposable class, this statement
             * is automatically called at the end of using the class.
             */
            try
            {
                connection.Close();
                connection.Dispose();
            }
            catch (Exception e)
            {
                /* This should not happen but the user should not be
                 * interupted if it does. It's not catastrophic and
                 * can be closed later.
                 */
                Debug.WriteLine(e);
            }
        }
    }
}
