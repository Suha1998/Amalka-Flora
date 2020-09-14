using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace AmalkaFlora
{
    class FLOWERPRO
    {
        MY_DB db = new MY_DB();

        //Insert a new Product
        public bool insertProduct(string category, string productName, int proPrice, string description, MemoryStream image)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `ex5`( `category`, `productName`, `proPrice`, `description`, `image`) VALUES (@cat,@pn,@pr,@des,@img)", db.getConnection);

            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = category;
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = productName;
            command.Parameters.Add("@pr", MySqlDbType.Int32).Value = proPrice;
            command.Parameters.Add("@des", MySqlDbType.VarChar).Value = description;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = image.ToArray();


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
        //Edit product

        public bool editFlowerProducts(int productID, string category, string productName, string proPrice, string description,  MemoryStream image)
        {
            //MySqlCommand command = new MySqlCommand("UPDATE `ex5` SET `category`=@cat,`productName`=@pn,`proPrice`=@pr,`description`=@des,`image`=@img WHERE productID`=@id", db.getConnection);
            MySqlCommand command = new MySqlCommand("UPDATE `ex5` SET `category`=@cat,`productName`=@pn,`proPrice`=@pr,`description`=@des,`image`=@img WHERE productID=@id", db.getConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = productID;
            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = category;
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = productName;
            command.Parameters.Add("@pr", MySqlDbType.Int32).Value = proPrice;
            command.Parameters.Add("@des", MySqlDbType.VarChar).Value = description;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = image.ToArray();



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
        public bool deleteProducts(int productID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `ex5` WHERE `productID`=@id", db.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = productID;


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


    }
}
