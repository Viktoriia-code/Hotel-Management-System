﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    internal class ROOM
    {
        CONNECT conn = new CONNECT();
        public DataTable roomTypeList()
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_category`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public DataTable roomByType(int type)
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms` WHERE `type`=@typ and free='Yes'", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            //@typ
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = type;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool addRoom(int number, int type, String phone, String free)
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES (@num,@tp,@phn,@fr)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // @num,@tp,@phn,@fr
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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
        public DataTable getRooms()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool editRoom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `rooms` SET `type`=@tp,`phone`=@phn,`free`=@fr WHERE `number`=@num";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @num,@tp,@phn,@fr
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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

        public bool removeRoom(int number)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `rooms` WHERE `number`=@num";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            // @num
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

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
