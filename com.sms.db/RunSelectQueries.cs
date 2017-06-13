using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using com.sms.config;
using System.Data.SQLite;

namespace com.sms.db
{
    class RunSelectQueries
    {
        public static DataTable Select(string Query)
        {
            SQLiteConnection conn = Conn.GetConnection();
            DataTable dataTable = new DataTable();
            try
            {
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(Query, conn);
                sqlda.Fill(dataTable);
                
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());                
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return dataTable;
        }
    }
}
