using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace HotelManagementSystem
{
    class CLIENT
    {
        CONNECT conn = new CONNECT();
        public bool insertClient(String fname, String lname, String country, String phone)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `country`, `phone`) VALUES (@fnm,@lnm,@cnt,@phn)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // @fnm,@lnm,@cnt,@phn
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;  
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }
}
