using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ManageClientsForm : Form
    {
        CLIENT client = new CLIENT();
        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void emptyBTN_Click(object sender, EventArgs e)
        {
            firstNameTB.Text = "";
            lastNameTB.Text = "";
            countryTB.Text = "";
            phoneTB.Text = "";
            userLoginTB.Text = "";
            userPasswordTB.Text = "";
        }

        private void addClientBTN_Click(object sender, EventArgs e)
        {
            String fname = firstNameTB.Text;
            String lname = lastNameTB.Text;
            String country = countryTB.Text;
            String phone = phoneTB.Text;

            Boolean insertClient = client.insertClient(fname, lname, country, phone);

            if (insertClient)
            {
                MessageBox.Show("New Client Inserted Successfully", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR - Client Not Inserted", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
