using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectDB
{
    public class ConnectDB
    {
        public class Connection
        {
            //public string server = "10.90.12.110"; 
            public string server = "chuc.caseum.ru";
            public string port = "33333";
            public string user = "st_1_20_13";
            public string database = "is_1_20_st13_KURS";
            public string password = "31485311";
            public string ConnStr;
            public string connect()
            {
                return ConnStr = $"server={server};port={port};user={user};database={database};password={password};";
            }

        }


    }
}
