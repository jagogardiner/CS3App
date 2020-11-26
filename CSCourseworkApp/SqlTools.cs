using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

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
        private static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CSDb.mdf;Integrated Security = True";
        // Make reader public for executeReader usage.
        public SqlDataReader reader;

        public SqlDataReader executeReader(SqlCommand command)
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

        public SqlDataReader executeReader(string query)
        {
            /*
             * executeReader returns an SqlDataReader to read
             * from data based on the query string provided.
             * 
             * Arguments: 
             * query (string): sql query to read data from
            */
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            /* Note that try catch isn't attempted
             * SqlCommand has its own valid exceptions
             * and catches should be used in local scope instead
             */
            return command.ExecuteReader();
        }

        public int executeScalar(SqlCommand command)
        {
            /*
             * executeScalar returns an integer-casted scalar
             * to read integer values from a query instead of
             * creating a new reader object.
             * 
             * Arguments:
             * command (SqlCommand): SQL command query object
             */
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                // Make sure we cast int on scalar
                return (int)command.ExecuteScalar();
            }
        }

        public int executeScalar(string query)
        {
            /*
             * executeScalar returns an integer-casted scalar
             * to read integer values from a query instead of
             * creating a new reader object.
             * 
             * Arguments:
             * query (string): sql query to read integer from
             */
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                // Make sure we cast int on scalar
                return (int)command.ExecuteScalar();
            }
        }

        public int getRows(string table)
        {
            /*
             * getRows returns an integer value of the amount
             * of rows in a table using the executeScalar function.
             * 
             * Arguments:
             * table (string): Table name to get rows of.
             */
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM "+table, connection);
                return (int)command.ExecuteScalar();
            }
        }

        public static List<string> getDbTableNames()
        {
            /*
             * getDbTableNames gets the connected database
             * table names to be populated later on into a DataTable
             * or DataSet, returned as a list of strings.
             */
            using(connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.GetSchema("Tables").AsEnumerable().Select(x => x[2].ToString()).ToList();
            }
        }

        public string getJoinResult(SqlCommand command)
        {
            string result = null;
            using (SqlTools t = new SqlTools())
            {
                t.reader = t.executeReader(command);
                while(t.reader.Read())
                {
                    result = t.reader[0].ToString();
                }
            }
            return result;
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
