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
            List<string[]> foreignKeys = new List<string[]>();
            foreach(DataTable dt in CSDatabase.Tables)
            {
                foreach (DataColumn c in dt.Columns)
                {
                    if (c.ColumnName.Contains("FK_"))
                    {
                        string[] keys = {c.ColumnName, c.ColumnName.Substring(3, c.ColumnName.Length - 3)};
                        foreignKeys.Add(keys);
                    }
                }
            }
            foreach (DataTable find in CSDatabase.Tables)
            {
                foreach (DataColumn ctofind in find.Columns)
                {
                    foreach (string[] key in foreignKeys)
                    {
                        if (ctofind.ColumnName == key[0])
                        {
                            foreach (DataTable dt in CSDatabase.Tables)
                            {
                                foreach (DataColumn realc in dt.Columns)
                                {
                                    if (realc.ColumnName == key[1])
                                    {
                                        CSDatabase = createRelation(CSDatabase, realc, ctofind, key[0]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
#if DEBUG
            foreach (DataRelation dr in CSDatabase.Relations)
            {
                Debug.WriteLine(dr.RelationName);
            }
        }
#endif

        private static DataSet createRelation(DataSet ds, DataColumn parent, DataColumn child, string fkname)
        {
            DataRelation dr = new DataRelation(fkname, parent, child);
            ds.Relations.Add(dr);
            return ds;
        }
    }
}