using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

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
        //function to get a client list
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //function to edit a client
        public bool editClient(int id, String fname, String lname, String country, String phone)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `clients` SET `first_name`=@fnm,`last_name`=@lnm,`country`=@cnt,`phone`=@phn WHERE `id`=@cid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @cid,@fnm,@lnm,@cnt,@phn
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
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

        //function to delete a client
        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `clients` WHERE `id`=@cid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            // @cid
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;

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
