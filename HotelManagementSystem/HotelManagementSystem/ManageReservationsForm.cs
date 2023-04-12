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
    public partial class ManageReservationsForm : Form
    {
        public ManageReservationsForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        RESERVATION reservation = new RESERVATION();
        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {
            roomTypeCB.DataSource = room.roomTypeList();
            roomTypeCB.DisplayMember = "label";
            roomTypeCB.ValueMember = "category_id";
        }

        private void emptyBTN_Click(object sender, EventArgs e)
        {
            clientNumTB.Text = "";
            roomTypeCB.SelectedIndex = 0;
            dateInTP.Value = DateTime.Now;
            dateOutTP.Value = DateTime.Now;
        }

        private void roomTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int type = Convert.ToInt32(roomTypeCB.SelectedValue.ToString());
                roomNumberCB.DataSource = room.roomByType(type);
                roomNumberCB.DisplayMember = "number";
                roomNumberCB.ValueMember = "number";
            }
            catch(Exception)
            {
                //do nothing
            }
        }

        private void addBookingBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = Convert.ToInt32(clientNumTB.Text);
                int roomNumber = Convert.ToInt32(roomNumberCB.SelectedValue);
                DateTime dateIn = dateInTP.Value;
                DateTime dateOut = dateOutTP.Value;

                // date in must be = or > today date
                // date out must be = or > date in
                if (DateTime.Compare(dateIn.Date, DateTime.Now.Date) < 0)
                {
                    MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DateTime.Compare(dateOut.Date, dateIn.Date) < 0)
                {
                    MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.addReservation(roomNumber, clientID, dateIn, dateOut))
                    {
                        // set the room free column to NO
                        // you can add a message if the room is edited
                        room.setRoomFree(roomNumber, "No");
                        reservationDataGridView.DataSource = reservation.getAllReserv();
                        MessageBox.Show("New Reservation Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation NOT Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
