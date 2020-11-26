using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace CSCourseworkApp
{
    class Datasets
    {
        // Make our dataset and tables public for every class
        public static DataSet CSDatabase = new DataSet();
        public static List<string> tableNames = SqlTools.getDbTableNames();

        public static void populateTables()
        {
            /*
             * populateTables populates the CSDatabase DataSet
             * with DataTables from the SQL database, CSDb.mdf,
             * and adds the foreign key relations.
             * This way, we don't have to worry about MySQL connections
             * with every command.
             */
            using(SqlTools tools = new SqlTools())
            {
                foreach (string tablename in tableNames)
                {
                    // Populate a new datatable from SQL DB
                    DataTable d = tools.populateDataTable(tablename);
                    // Add it to our Database DataSet
                    CSDatabase.Tables.Add(d);
                    // Make sure we assign the table name to correctly identify it 
                    d.TableName = tablename;
                }
            }
            List<string> foreignKeys = new List<string>();
            List<string> actualKeys = new List<string>();
            foreach(DataTable dt in CSDatabase.Tables)
            {
                foreach(DataColumn c in dt.Columns)
                {
                    if (c.ColumnName.Contains("FK_"))
                    {
                        foreignKeys.Add(c.ColumnName);
                        actualKeys.Add(c.ColumnName.Substring(3, c.ColumnName.Length - 3));
                        foreach(DataTable find in CSDatabase.Tables)
                        {
                            foreach(DataColumn ctofind in dt.Columns)
                            {
                                foreach(string key in actualKeys)
                                {
                                    if(ctofind.ColumnName == key)
                                    {
                                        CSDatabase = createRelation(CSDatabase, c, ctofind, c.ColumnName);
                                    }
                                }
                            }
                            foreach (ForeignKeyConstraint cs in find.Constraints)
                            {
                                Debug.WriteLine(cs.ConstraintName);
                            }
                        }
                    }
                }
            }
        }

        private static DataSet createRelation(DataSet ds, DataColumn parent, DataColumn child, string fkname)
        {
            DataRelation dr = new DataRelation(fkname, parent, child);
            ds.Relations.Add(dr);
            return ds;
        }
    }
}
