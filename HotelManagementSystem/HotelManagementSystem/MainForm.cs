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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ManageClientsBTN_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageCF = new ManageClientsForm();
            manageCF.ShowDialog();
        }

        private void ManageBookingBTN_Click(object sender, EventArgs e)
        {
            ManageReservationsForm manageRSVF = new ManageReservationsForm();
            manageRSVF.ShowDialog();
        }

        private void ManageRoomsBTN_Click(object sender, EventArgs e)
        {
            ManageRoomsForm manageRF = new ManageRoomsForm();
            manageRF.ShowDialog();
        }
    }
}
