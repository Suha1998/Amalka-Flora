using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace AmalkaFlora
{
    class EMPLOYEE
    {
        MY_DB db = new MY_DB();

        //Insert a new employee
        public bool insertEmployee(string name, string tel, string addr, string email, string empType, string sal, MemoryStream photo,string nic)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `ex3`( `name`, `tel`, `addr`, `email`, `empType`, `sal`, `photo`, `nic`) VALUES (@en,@et,@eadd,@eem,@eet,@esal,@epic,@enic)", db.getConnection);

            command.Parameters.Add("@en", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@et", MySqlDbType.VarChar).Value = tel;
            command.Parameters.Add("@eadd", MySqlDbType.VarChar).Value = addr;
            command.Parameters.Add("@eem", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@eet", MySqlDbType.VarChar).Value = empType;
            command.Parameters.Add("@esal", MySqlDbType.VarChar).Value = sal;
            command.Parameters.Add("@epic", MySqlDbType.LongBlob).Value = photo.ToArray();
            command.Parameters.Add("@enic", MySqlDbType.VarChar).Value = nic;

            



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

        //Edit Employee

        public bool editEmployee(int id, string name, string tel, string addr, string email, string empType, string sal, MemoryStream photo, string nic)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `ex3` SET `name`=@en,`tel`=@et,`addr`=@eadd,`email`=@eem,`empType`=@eet,`sal`=@esal,`photo`=@epic,`nic`=@enic WHERE `id`=@id", db.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@en", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@et", MySqlDbType.VarChar).Value = tel;
            command.Parameters.Add("@eadd", MySqlDbType.VarChar).Value = addr;
            command.Parameters.Add("@eem", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@eet", MySqlDbType.VarChar).Value = empType;
            command.Parameters.Add("@esal", MySqlDbType.VarChar).Value = sal;
            command.Parameters.Add("@epic", MySqlDbType.LongBlob).Value = photo.ToArray();
            command.Parameters.Add("@enic", MySqlDbType.VarChar).Value = nic;
            

            //@id,@en,@et,@eadd,@eem,@eet,@esal,@epic,@enic





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

        //Create a function to delete the selected employee
        public bool deleteEmployee(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `ex3` WHERE `id`=@id", db.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            

            //@id,@en,@et,@eadd,@eem,@eet,@esal,@epic,@enic





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

       

        //Function to return a list of contacts depending on the given command
        public DataTable selectEmployeeList(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        




















    }
}
