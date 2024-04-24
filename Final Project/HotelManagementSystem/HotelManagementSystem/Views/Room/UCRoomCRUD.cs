using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Entities.Guest;
using HotelManagementSystem.Entities.Reservation;
using HotelManagementSystem.Entities.Room;
using HotelManagementSystem.Services.Employee;
using HotelManagementSystem.Services.Reservation;
using HotelManagementSystem.Services.Room;
using HotelManagementSystem.Views.Employee;
using HotelManagementSystem.Views.Menu;
using HotelManagementSystem.Views.Reservation;

namespace HotelManagementSystem.Views.Room
{
    public partial class UCRoomCRUD : UserControl
    {
        UCRoomList uCRoomList = new UCRoomList();
        RoomService roomservice = new RoomService();
        public string ID
        { set { txtRoomID.Text = value; } }
        public UCRoomCRUD()
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

        private void AddorUpdateRoom()
        {
            
            RoomEntity roomEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(txtRoomID.Text))
            {
                success = roomservice.InsertRoom(roomEntity);
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
                success = roomservice.UpdateRoom(roomEntity);
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
            roomEntity.room_number=txtRoomNumber.Text;
            roomEntity.room_type = cbType.Text;
            roomEntity.price = Convert.ToInt32(txtPrice.Text);
            roomEntity.is_occupied = false;
            roomEntity.created_date= DateTime.Now;
            return roomEntity;
        }      
        private void clearAll()
        {
            txtRoomNumber.Text = string.Empty;
            cbType.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }    
        private void UCRoomCRUD_Load(object sender, EventArgs e)
        {
            BindData();
            btnControl();
        }

        private void BindData()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtRoomID.Text))
                {
                    DataTable dt = roomservice.Get(Convert.ToInt32(txtRoomID.Text));

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

        private void btnAdd_Click_1(object sender, EventArgs e)
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

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            UCDashboard uCDashboard = new UCDashboard();
            this.Controls.Clear();
            this.Controls.Add(uCDashboard);
        }
    }
}
