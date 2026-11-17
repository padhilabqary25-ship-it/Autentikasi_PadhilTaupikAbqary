using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SchoolAppLoginandRegister3
{
    internal class Connection
    {
        public MySqlConnection ConnectionToSQL()
        {
            string strConnection = "Server=localhost;Database=pi_school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }
    }
}
