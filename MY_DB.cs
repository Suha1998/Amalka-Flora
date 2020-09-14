using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AmalkaFlora
{
    class MY_DB
    {
        //The connection
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=floral_shop_db");

        //return the connection
        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        //Open the connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //Close the connection
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
