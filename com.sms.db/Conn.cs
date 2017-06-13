using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using com.sms.config;
using System.Windows;

namespace com.sms.db
{
    class Conn
    {
        public static SQLiteConnection GetConnection()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(ConfigStrings.CONNECTION_STRING);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
    }
}
