using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Entities.Reservation;
using HotelManagementSystem.Entities.Room;
using HotelManagementSystem.Services.Reservation;
using HotelManagementSystem.Services.Room;
using HotelManagementSystem.Views.Menu;
using HotelManagementSystem.Views.Reservation;

namespace HotelManagementSystem.Views.Room
{
    public partial class UCRoomCRUD : UserControl
    {
        UCRoomList uCRoomList = new UCRoomList();
        public string ID
        { set { roomID.Text = value; } }
        public UCRoomCRUD()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string roomNumber=txtRoomNumber.Text,roomType=cbType.Text,Price=txtPrice.Text;
            if (string.IsNullOrWhiteSpace(roomNumber))
            {
                MessageBox.Show("Empty Room Number!");
            }
            else if (!roomNumber.Any(char.IsDigit)&&!roomNumber.Any(char.IsLetter))
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
            else
            {
                AddorUpdateRoom();
            }
        }

        private void AddorUpdateRoom()
        {
            RoomService roomservice = new RoomService();
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
            throw new NotImplementedException();
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
            UCRoomList uCRoomList = new UCRoomList();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UCDashboard uCDashboard = new UCDashboard();
            this.Controls.Clear();
            this.Controls.Add(uCDashboard);
        }
    }
}
