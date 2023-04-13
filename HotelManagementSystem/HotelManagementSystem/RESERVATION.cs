using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    internal class RESERVATION
    {
        CONNECT conn = new CONNECT();
        public DataTable getAllReserv()
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool addReservation(int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservations`(`roomNumber`, `clientId`, `dateIn`, `dateOut`) VALUES (@rnm,@cid,@din,@dout)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // @rnm,@cid,@din,@dout
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

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

        public bool editReserv(int reservId, int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `reservations` SET `roomNumber`=@rnm,`clientId`=@cid,`dateIn`=@din,`dateOut`=@dout WHERE `reservId`=@rvid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @rnm,@cid,@din,@dout,@rvid
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservId;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

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

        public bool removeReserv(int rsv_id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `reservations` WHERE `reservId`=@rvid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            // @rvid
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = rsv_id;

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

//ALTER TABLE rooms add CONSTRAINT fk_type_id FOREIGN KEY (type) REFERENCES rooms_category(category_id) on UPDATE CASCADE on DELETE CASCADE;
//ALTER TABLE reservations add CONSTRAINT fk_room_id FOREIGN KEY (roomNumber) REFERENCES rooms(number) on UPDATE CASCADE on DELETE CASCADE;
//ALTER TABLE reservations add CONSTRAINT fk_client_id FOREIGN KEY (clientId) REFERENCES clients(id) on UPDATE CASCADE on DELETE CASCADE;
