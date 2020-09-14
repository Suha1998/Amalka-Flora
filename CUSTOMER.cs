using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace AmalkaFlora
{
    class CUSTOMER
    {
        MY_DB db = new MY_DB();

        //Function to check the username

        public bool usernameExists(string userName)
        {
            string query = "SELECT * FROM `ex1` WHERE `userName`=@un";
            MySqlCommand command = new MySqlCommand(query, db.getConnection);
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = userName;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            //if the customer exists return true

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Insert a new customer
        public bool insertCustomer(string name, string addr, string contact, string gender, string email, string userName, string password, string cPassword, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `ex1`(`name`, `addr`, `contact`, `gender`, `email`, `userName`, `password`, `cPassword`, `picture`) VALUES (@cn,@ad,@cont,@gen,@em,@un,@ps,@cps,@pict)", db.getConnection);

            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = addr;
            command.Parameters.Add("@cont", MySqlDbType.VarChar).Value = contact;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@cps", MySqlDbType.VarChar).Value = cPassword;
            command.Parameters.Add("@pict", MySqlDbType.LongBlob).Value = picture.ToArray();



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


        //Edit customer

        public bool editCustomer(int id, string name, string addr, string contact, string gender,string email, string userName, string password,string cPassword, MemoryStream picture)
        {
            
            MySqlCommand command = new MySqlCommand("UPDATE `ex1` SET `name`=@custname,`addr`=@custaddr,`contact`=@custcont,`gender`=@custgen,`email`=@custemail,`userName`=@custuname,`password`=@custps,`cPassword`=@custccps,`picture`=@pic WHERE `id`=@custid", db.getConnection);

            command.Parameters.Add("@custid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@custname", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@custaddr", MySqlDbType.VarChar).Value = addr;
            command.Parameters.Add("@custcont", MySqlDbType.VarChar).Value = contact;
            command.Parameters.Add("@custgen", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@custemail", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@custuname", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@custps", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@custccps", MySqlDbType.VarChar).Value = cPassword;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();



            //@custid @custname @custaddr @custcont @custgen @custemail @custuname @custps @custccps @pic



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

        //Create a function to delete the selected customer
        public bool deleteCustomer(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `ex1` WHERE `id`=@custid", db.getConnection);

            command.Parameters.Add("@custid", MySqlDbType.Int32).Value = id;


      





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
