using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"server\LOCALINSTANCE";
            string database = "PhoneBookDB";
            string username = "sa";
            string password = "password goes here";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}