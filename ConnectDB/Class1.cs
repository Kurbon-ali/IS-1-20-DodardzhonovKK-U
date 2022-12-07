using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectDB
{
    public class Class1
    {
        //string server = "10.90.12.110";
        string server = "chuc.caseum.ru";
        string port = "33333";
        string user = "st_1_20_13";
        string db = "is_1_20_st13_KURS";
        string password = "31485311";
        public string connStr;
        public string Conn()
        {
            return connStr = $"хост={server};порт={port};пользовтаель={user};базаданных={db};пароль={password}";
        }

    }
}
