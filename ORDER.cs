using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AmalkaFlora
{
    class ORDER
    {
        MY_DB db = new MY_DB();
        //Insert a new order
        public bool insertOrder(string name,string email,string tele,string flowerName,int quantity,DateTime odate,string time,string branch)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `flower_order`( `name`,`email`, `tele`, `flowerName`, `quantity`, `odate`, `time`, `branch`) VALUES (@en,@em,@et,@eadd,@eem,@eet,@esal,@es)", db.getConnection);

            command.Parameters.Add("@en", MySqlDbType.VarChar).Value = name; 
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@et", MySqlDbType.VarChar).Value = tele;
            command.Parameters.Add("@eadd", MySqlDbType.VarChar).Value = flowerName;
            command.Parameters.Add("@eem", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("@eet", MySqlDbType.Date).Value = odate;
            command.Parameters.Add("@esal", MySqlDbType.VarChar).Value = time;
            command.Parameters.Add("@es", MySqlDbType.VarChar).Value = branch;






            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }
    }
}
