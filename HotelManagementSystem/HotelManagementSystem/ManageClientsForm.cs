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
            ClientIDTB.Text = "";
            firstNameTB.Text = "";
            lastNameTB.Text = "";
            countryTB.Text = "";
            phoneTB.Text = "";
        }

        private void addClientBTN_Click(object sender, EventArgs e)
        {
            String fname = firstNameTB.Text;
            String lname = lastNameTB.Text;
            String country = countryTB.Text;
            String phone = phoneTB.Text;

            if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - First & Last name + Phone number", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean insertClient = client.insertClient(fname, lname, country, phone);

                if (insertClient)
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("New Client Inserted Successfully", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Inserted", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClients();
        }

        private void editClientBTN_Click(object sender, EventArgs e)
        {
            int id;
            String fname = firstNameTB.Text;
            String lname = lastNameTB.Text;
            String country = countryTB.Text;
            String phone = phoneTB.Text;

            try
            {
                id = Convert.ToInt32(ClientIDTB.Text);
                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
                {
                    MessageBox.Show("Required Fields - First & Last name + Phone number", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = client.editClient(id, fname, lname, country, phone);

                    if (insertClient)
                    {
                        dataGridView1.DataSource = client.getClients();
                        MessageBox.Show("New Client Updated Successfully", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Client Not Updated", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //display the selected client data from datagridview
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientIDTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            firstNameTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lastNameTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            countryTB.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            phoneTB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void deleteClientBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ClientIDTB.Text);

                if (client.removeClient(id))
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("Client Deleted Successfully", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    emptyBTN.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Deleted", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
