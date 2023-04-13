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
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }
        ROOM room = new ROOM();
        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            roomTypeCB.DataSource = room.roomTypeList();
            roomTypeCB.DisplayMember = "label";
            roomTypeCB.ValueMember = "category_id";

            roomDataGridView.DataSource = room.getRooms();
        }

        private void addRoomBTN_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(roomNumberTB.Text);
            int type = Convert.ToInt32(roomTypeCB.SelectedValue.ToString());
            string phone = roomPhoneTB.Text;
            string free = "Yes";
            if (FreeRoomRadioBTN.Checked)
            {
                free = "Yes";
            }
            else if (NotFreeRoomRadioBTN.Checked)
            {
                free = "No";
            }
            if (room.addRoom(number,type,phone,free))
            {
                roomDataGridView.DataSource = room.getRooms();
                MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearRoomBTN_Click(object sender, EventArgs e)
        {
            roomNumberTB.Text = "";
            roomTypeCB.SelectedIndex = 0;
            roomPhoneTB.Text = "";
        }

        private void roomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomNumberTB.Text = roomDataGridView.CurrentRow.Cells[0].Value.ToString();
            roomTypeCB.SelectedValue = roomDataGridView.CurrentRow.Cells[1].Value;
            roomPhoneTB.Text = roomDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void editRoomBTN_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(roomTypeCB.SelectedValue.ToString());
            String phone = roomPhoneTB.Text;
            String free = "";

            try
            {
                int number = Convert.ToInt32(roomNumberTB.Text);
                if(FreeRoomRadioBTN.Checked)
                {
                    free = "Yes";
                }
                else if(NotFreeRoomRadioBTN.Checked)
                {
                    free = "No";
                }
                if(room.editRoom(number,type,phone,free))
                {
                    roomDataGridView.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteRoomBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(roomNumberTB.Text);

                if (room.removeRoom(number))
                {
                    roomDataGridView.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
