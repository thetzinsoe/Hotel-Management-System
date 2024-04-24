using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Entities.Room;
using HotelManagementSystem.Services.Room;
using HotelManagementSystem.Views.Menu;

namespace HotelManagementSystem.Views.Room
{
    
    public partial class UCRoomCrud : UserControl
    {
        UCRoomList uCRoomList = new UCRoomList();
        RoomService roomService = new RoomService();
        public string ID
        { set {  txtRoomID.Text= value; } }
        public UCRoomCrud()
        {
            InitializeComponent();
        }
        private bool vaildInput()
        {
            string roomNumber = txtRoomNumber.Text, roomType = cbType.Text, Price = txtPrice.Text;
            if (string.IsNullOrWhiteSpace(roomNumber))
            {
                MessageBox.Show("Empty Room Number!");
            }
            else if (!roomNumber.Any(char.IsDigit) && !roomNumber.Any(char.IsLetter))
            {
                MessageBox.Show("Invalid Room Number");
            }
            else if (string.IsNullOrWhiteSpace(roomType))
            {
                MessageBox.Show("Empty Room Type!");
            }
            else if (string.IsNullOrWhiteSpace(Price))
            {
                MessageBox.Show("Empty Room Price!");
            }
            else if (Price.Any(char.IsLetter))
            {
                MessageBox.Show("Invalid input should be digits!");
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!vaildInput())
            {
                return;
            }
            else
            {
                AddorUpdateRoom();
            }
        }
        private void AddorUpdateRoom()
        {

            RoomEntity roomEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(txtRoomID.Text))
            {
                success = roomService.InsertRoom(roomEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                    this.Controls.Clear();
                    this.Controls.Add(uCRoomList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Reservation Adding!");
                }
            }
            else
            {
                success = roomService.UpdateRoom(roomEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                    this.Controls.Clear();
                    this.Controls.Add(uCRoomList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Updating Reservation!");
                }
            }
        }
        private RoomEntity CreateData()
        {
            RoomEntity roomEntity = new RoomEntity(); ;
            if (!String.IsNullOrEmpty(txtRoomID.Text))
            {
                roomEntity.room_id = Convert.ToInt32(txtRoomID.Text);
            }
            roomEntity.room_number = txtRoomNumber.Text;
            roomEntity.room_type = cbType.Text;
            roomEntity.price = decimal.Parse(txtPrice.Text.ToString());
            roomEntity.is_occupied = 0;
            roomEntity.created_date = DateTime.Now;
            roomEntity.updated_date = DateTime.Now;
            return roomEntity;
        }
        private void BindData()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtRoomID.Text))
                {
                    DataTable dt = roomService.Get(Convert.ToInt32(txtRoomID.Text));

                    if (dt.Rows.Count > 0)
                    {

                        txtRoomNumber.Text = dt.Rows[0]["RoomNumber"].ToString();
                        cbType.Text = dt.Rows[0]["Type"].ToString();
                        txtPrice.Text = dt.Rows[0]["Price"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnControl()
        {
            if (!String.IsNullOrEmpty(txtRoomID.Text))
            {
                btnAdd.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
            else
            {
                btnAdd.Text = "ADD";
                btnDelete.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtRoomNumber.Text = string.Empty;
            cbType.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RoomService roomService = new RoomService();

            int roomId = Convert.ToInt32(txtRoomID.Text);
            bool success = false;
            success = roomService.DeleteRoom(roomId);
            if (success)
            {
                MessageBox.Show("Delete success", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK);
            }
            this.Controls.Clear();
            this.Controls.Add(uCRoomList);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UCDashboard uCDashboard = new UCDashboard();
            this.Controls.Clear();
            this.Controls.Add(uCDashboard);
        }

        private void UCRoomCrud_Load(object sender, EventArgs e)
        {
            BindData();
            btnControl();
        }
    }
}
