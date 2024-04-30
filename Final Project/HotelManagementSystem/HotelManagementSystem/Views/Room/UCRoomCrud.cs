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
        public string ROOMNumber 
        { set { txtRoomNumber.Text= value; } }
        public UCRoomCrud()
        {
            InitializeComponent();
        }
        private bool vaildInput()
        {
            string roomNumber = txtRoomNumber.Text, roomType = cbType.Text, Price = txtPrice.Text;
            try
            {
                DataTable dt = roomService.SearchbyRoomNumber(roomNumber);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Room Number already in use!");
                    return false;
                }
            }
            catch
            {
                return true;
            }
            if (string.IsNullOrWhiteSpace(roomNumber))
            {
                MessageBox.Show("Empty Room Number!");
                return false;
            }
             if (!roomNumber.Any(char.IsDigit) || !roomNumber.Any(char.IsLetter))
            {
                MessageBox.Show("Invalid Room Number!Eg. A-101");
                return false ;
            }
             if (string.IsNullOrWhiteSpace(roomType))
            {
                MessageBox.Show("Empty Room Type!");
                return false;
            }
             if (string.IsNullOrWhiteSpace(Price))
            {
                MessageBox.Show("Empty Room Price!");
                return false;
            }
              if (Price.Any(char.IsLetter))
            {
                MessageBox.Show("Invalid input should be digits!");
                return false;
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
                    MessageBox.Show("Something Wrong in Room Adding!");
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
                    MessageBox.Show("Something Wrong in Updating Room!");
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
            roomEntity.room_type = cbType.SelectedItem.ToString();
            roomEntity.room_price = decimal.Parse(txtPrice.Text.ToString());
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
                        txtRoomID.Text = dt.Rows[0]["room_id"].ToString();
                        txtRoomNumber.Text = dt.Rows[0]["room_no"].ToString();
                        cbType.Text = dt.Rows[0]["room_type"].ToString();
                        txtPrice.Text = dt.Rows[0]["room_price"].ToString();
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
                MessageBox.Show("Delete Room success", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error deleting Room", "Error", MessageBoxButtons.OK);
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

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbType.SelectedIndex)
            {
                case 0:
                    txtPrice.Text = "20000";
                    break;
                case 1:
                    txtPrice.Text = "24000";
                    break;
                case 2:
                    txtPrice.Text = "30000";
                    break;
                case 3:
                    txtPrice.Text = "34000";
                    break;
                case 4:
                    txtPrice.Text = "38000";
                    break;
                case 5:
                    txtPrice.Text = "44000";
                    break;
                case 6:
                    txtPrice.Text = "50000";
                    break;
            }
        }
    }
}
