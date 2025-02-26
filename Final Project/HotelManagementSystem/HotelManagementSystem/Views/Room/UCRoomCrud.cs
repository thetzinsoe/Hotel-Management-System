﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Entities.Room;
using HotelManagementSystem.Services.Reservation;
using HotelManagementSystem.Services.Room;
using HotelManagementSystem.Views.Menu;

namespace HotelManagementSystem.Views.Room
{
    public partial class UCRoomCrud : UserControl
    {
        private bool userHasSelected=false;
        UCRoomList uCRoomList = new UCRoomList();
        RoomService roomService = new RoomService();
        private int isOccupied = 0;
        public string ID
        { set {  txtRoomID.Text= value; } }
        public string ROOMNumber 
        { set { txtRoomNumber.Text= value; } }
        public UCRoomCrud()
        {
            InitializeComponent();
            cbType.Text = "Select Room Type";
        }
        private bool vaildInput()
        {
            string roomNumber = txtRoomNumber.Text, roomType = cbType.Text, Price = txtPrice.Text;
            if (string.IsNullOrWhiteSpace(roomNumber))
            {
                MessageBox.Show("Empty Room Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
             if (!roomNumber.Any(char.IsDigit) || !roomNumber.Any(char.IsLetter))
            {
                MessageBox.Show("Invalid Room Number!Eg. A-101","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false ;
            }
            if (roomNumber.Length > 6)
            {
                MessageBox.Show("Invalid Room Number!Eg. A-101", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
             if (cbType.SelectedIndex<0||cbType.SelectedText==null)
            {
                MessageBox.Show("Empty Room Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
             if (string.IsNullOrWhiteSpace(Price))
            {
                MessageBox.Show("Empty Room Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
              if (Price.Any(char.IsLetter))
            {
                MessageBox.Show("Invalid input! Price should be digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Price.Any(char.IsNumber))
            {
                MessageBox.Show("Price should only be whole numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Price.Length > 6)
            {
                MessageBox.Show("Invalid Price! Please Type correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                DataTable dt = roomService.SearchbyRoomNumber(txtRoomNumber.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Room Number already in use!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    success = roomService.InsertRoom(roomEntity);
                    if (success)
                    {
                        MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Controls.Clear();
                        this.Controls.Add(uCRoomList);
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong in Room Adding!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }                                 
            }
            else
            {
                ReservationService reservationService = new ReservationService();
                DataTable dt = reservationService.haveRoom(Convert.ToInt32(txtRoomID.Text));
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("This room is using in current time, Can't any changes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                }
                else
                {
                    success = roomService.UpdateRoom(roomEntity);
                    if (success)
                    {
                        isOccupied = 0;
                        MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Controls.Clear();
                        this.Controls.Add(uCRoomList);
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong in Updating Room!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            roomEntity.room_number = txtRoomNumber.Text.Trim();
            roomEntity.room_type = cbType.Text;
            roomEntity.room_price = decimal.Parse(txtPrice.Text.ToString());
            roomEntity.is_occupied = (short)isOccupied;
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
                        isOccupied = int.Parse(dt.Rows[0]["is_occupied"].ToString());
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
                txtRoomNumber.Enabled=false;
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
            int roomId = Convert.ToInt32(txtRoomID.Text);
            ReservationService reservationService = new ReservationService();
            DataTable dt = reservationService.haveRoom(roomId);
            bool res = false;
            if (dt.Rows.Count >0)
            {
                res = false;
                MessageBox.Show("This room is already checkin or reservation!.","Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                res = true;
            }
            RoomService roomService = new RoomService();         
            if (res)
            {
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
            }
           
            this.Controls.Clear();
            this.Controls.Add(uCRoomList);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDashBoard mainDashBoard= new MainDashBoard();
            this.Controls.Clear();
            this.Controls.Add(mainDashBoard);
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

        private void cbType_TextUpdate(object sender, EventArgs e)
        {
            if (!userHasSelected)
            {
                cbType.Text = "Select room type";
            }
        }

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            cbType.Text = "Select room type";
            if (cbType.SelectedIndex != -1)
            {
                userHasSelected = true;
            }
        }

        private void cbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
