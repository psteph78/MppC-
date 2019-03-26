using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AgentieDeTurismMpp.repository
{
    class JDBCUtils
    {
        private static SQLiteConnection connection = null; 

        public static SQLiteConnection getConnection()
        {
            if (connection == null || connection.State == System.Data.ConnectionState.Closed)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RConnString"].ConnectionString;
                connection = new SQLiteConnection(connectionString);
                connection.Open();
            }
            return connection;
        }
    }
}
