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
            // display room's type
            roomTypeCB.DataSource = room.roomTypeList();
            roomTypeCB.DisplayMember = "label";
            roomTypeCB.ValueMember = "category_id";

            // display room's number depending on the selected type
            int type = Convert.ToInt32(roomTypeCB.SelectedValue.ToString());
            roomNumberCB.DataSource = room.roomByType(type);
            roomNumberCB.DisplayMember = "number";
            roomNumberCB.ValueMember = "number";

            // show all reservations in the datagrid
            reservationDataGridView.DataSource = reservation.getAllReserv();
        }

        private void emptyBTN_Click(object sender, EventArgs e)
        {
            bookingNumberTB.Text = "";
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

        private void editBookingBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int rservID = Convert.ToInt32(bookingNumberTB.Text);
                int clientID = Convert.ToInt32(clientNumTB.Text);
                int roomNumber = Convert.ToInt32(reservationDataGridView.CurrentRow.Cells[1].Value.ToString());
                DateTime dateIn = dateInTP.Value;
                DateTime dateOut = dateOutTP.Value;

                // date in must be = or > today date
                // date out must be = or > date in
                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOut < dateIn)
                {
                    MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //rservId
                    if (reservation.editReserv(rservID, roomNumber, clientID, dateIn, dateOut))
                    {
                        // set the room free column to NO
                        // you can add a message if the room is edited
                        room.setRoomFree(roomNumber, "No");
                        reservationDataGridView.DataSource = reservation.getAllReserv();
                        MessageBox.Show("Reservation Data Updated", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void reservationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookingNumberTB.Text = reservationDataGridView.CurrentRow.Cells[0].Value.ToString();
            int roomId = Convert.ToInt32(reservationDataGridView.CurrentRow.Cells[1].Value.ToString());
            roomTypeCB.SelectedValue = room.getRoomType(roomId);
            roomNumberCB.SelectedValue = roomId;
            clientNumTB.Text = reservationDataGridView.CurrentRow.Cells[2].Value.ToString();
            dateInTP.Value = Convert.ToDateTime(reservationDataGridView.CurrentRow.Cells[3].Value);
            dateOutTP.Value = Convert.ToDateTime(reservationDataGridView.CurrentRow.Cells[4].Value);
        }

        private void removeBookingBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(bookingNumberTB.Text);
                int roomNumber = Convert.ToInt32(reservationDataGridView.CurrentRow.Cells[1].Value.ToString());
                if (reservation.removeReserv(reservId))
                {
                    reservationDataGridView.DataSource = reservation.getAllReserv();
                    // after deleting a reservation we need to set free column to 'Yes'

                    room.setRoomFree(roomNumber, "Yes");
                    MessageBox.Show("Reservation Deleted", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
