using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    public partial class Kirjautumisikkuna : Form
    {
        public Kirjautumisikkuna()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value = userNameTB.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordTB.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mform = new MainForm();
                mform.Show();
            }
            else
            {
                if(userNameTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passwordTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This User or Password Doesn't Exist", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
