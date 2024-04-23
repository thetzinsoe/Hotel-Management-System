using HotelManagementSystem.Entities.CheckIn;
using HotelManagementSystem.Entities.Reservation;
using HotelManagementSystem.Services.CheckIn;
using HotelManagementSystem.Services.Reservation;
using HotelManagementSystem.Views.Payment;
using HotelManagementSystem.Views.Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Views.CheckIn
{
    public partial class UCCheckinAdd : UserControl
    {
        private bool validateInput = false;
        private string selectedRoomNo = string.Empty;
        private int selectedRoomId = 0;
        private string selectedGuestName = string.Empty;
        private string selectedGuestNrc = string.Empty;
        private int selectedGuestId = 0;
        UCCheckInList uCCheckInList = new UCCheckInList();
        CheckInEntity checkInEntity = new CheckInEntity();
        CheckInService checkInService = new CheckInService();
        ReservationService reservationService = new ReservationService();
        public string ID
        { set { hdCheckInId.Text = value; } }

        public string RvId
        {
            set { hdReservationId.Text = value;}
        }

        public string Nrc
        {
            set { hdGuestNrc.Text = value; }
        }


        public UCCheckinAdd()
        {
            InitializeComponent();
            dtpCheckInDate.MinDate = DateTime.Today.AddMonths(-6);
            dtpCheckInDate.MaxDate = DateTime.Today.AddMonths(1);
            dtpCheckOutDate.MinDate = DateTime.Today;
            dtpCheckOutDate.MaxDate = DateTime.Today.AddMonths(6);
        }

        private void UCCheckinAdd_Load(object sender, EventArgs e)
        {
            if (dtpCheckOutDate.Value.Date >= dtpCheckInDate.Value.Date)
            {
                validateInput = true;
                lbCheckOutValidation.Text = "";
            }
            else
            {
                validateInput = false;
                //lbCheckOutValidation.Text = "Wrong Date! Please choose the correct date.";
                MessageBox.Show("Wrong Date! Please choose the correct date.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                DataTable dtr = reservationService.GetAllRoom();
                cbRoomNumber.DataSource = dtr;
                cbRoomNumber.DisplayMember = "room_no";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            try
            {
                DataTable dt = checkInService.GetAllGuest();
                cbGuestName.DataSource = dt;
                cbGuestNrc.DataSource = dt;
                cbGuestName.DisplayMember = "full_name";
                cbGuestNrc.DisplayMember = "nrc_number";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BtnState();
            BindData();
        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (validateInput)
            {
                AddorUpdate();
            }
            else
            {
                MessageBox.Show("Some error occour! Please check the input value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddorUpdate()
        {
            CheckInEntity checkInEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(hdCheckInId.Text))
            {
                if (!string.IsNullOrEmpty(hdReservationId.Text))
                {
                   bool resDel = reservationService.Delete(int.Parse(hdReservationId.Text.ToString()));
                    if (!resDel)
                    {
                        MessageBox.Show("Cant remove reservation!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                success = checkInService.Insert(checkInEntity);
                bool roomOp = reservationService.RoomUpdate(selectedRoomId, 1);
                if (success && roomOp)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Controls.Clear();
                    this.Controls.Add(uCCheckInList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in creating Check In!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                success = checkInService.Update(checkInEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Controls.Clear();
                    this.Controls.Add(uCCheckInList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Updating Checkin!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }
        private CheckInEntity CreateData()
        {
            if (!String.IsNullOrEmpty(hdCheckInId.Text))
            {
                checkInEntity.checkin_id = Convert.ToInt32(hdCheckInId.Text);
            }
            checkInEntity.room_id = selectedRoomId;
            checkInEntity.guest_id = selectedGuestId;
            checkInEntity.checkin_date = dtpCheckInDate.Value.Date;
            checkInEntity.checkout_date = dtpCheckOutDate.Value.Date;
            return checkInEntity;
        }


        private void BtnState()
        {
            if (!string.IsNullOrEmpty(hdCheckInId.Text))
            {
                btnCheckOut.Enabled = true;
                btnCheckIn.Text = "Update";
            }
            else
            {
                btnCheckOut.Enabled = false;
                btnCheckIn.Text = "CheckIn";
            }
        }

        private void BindData()
        {
            try
            {
                if (!String.IsNullOrEmpty(hdCheckInId.Text))
                {
                    DataTable dt = checkInService.Get(Convert.ToInt32(hdCheckInId.Text.ToString()));
                    if (dt.Rows.Count > 0)
                    {
                        selectedRoomId = int.Parse(dt.Rows[0]["room_id"].ToString());
                        selectedRoomNo = dt.Rows[0]["room_no"].ToString();
                        cbRoomNumber.Text = dt.Rows[0]["room_no"].ToString();
                        //cbGuestName.SelectedItem = dt.Rows[0]["full_name"].ToString();
                        cbGuestNrc.Text = dt.Rows[0]["nrc_number"].ToString();
                        dtpCheckInDate.Text = dt.Rows[0]["checkin_date"].ToString();
                        dtpCheckOutDate.Text = dt.Rows[0]["checkout_date"].ToString();
                    }
                }else if(!string.IsNullOrEmpty(hdReservationId.Text)){
                    DataTable dt = reservationService.Get(Convert.ToInt32(hdReservationId.Text.ToString()));
                    if (dt.Rows.Count > 0)
                    {
                        selectedRoomId = int.Parse(dt.Rows[0]["room_id"].ToString());
                        selectedRoomNo = dt.Rows[0]["room_no"].ToString();
                        cbGuestNrc.Text = hdGuestNrc.Text;
                        cbRoomNumber.Text = dt.Rows[0]["room_no"].ToString();
                        dtpCheckInDate.Text = dt.Rows[0]["checkin_date"].ToString();
                        dtpCheckOutDate.Text = dt.Rows[0]["checkout_date"].ToString();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckInDate.Checked && String.IsNullOrEmpty(hdCheckInId.Text))
            {
                if (dtpCheckOutDate.Value.Date >= DateTime.Now.Date && dtpCheckOutDate.Value.Date >= dtpCheckInDate.Value.Date)
                {
                    validateInput = true;
                    lbCheckOutValidation.Text = "";
                }
                else
                {
                    validateInput = false;
                    lbCheckOutValidation.Text = "Wrong Date! Please choose the correct date.";
                }
            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckInDate.Checked && String.IsNullOrEmpty(hdCheckInId.Text))
            {
                if (dtpCheckInDate.Value.Date >= DateTime.Now.Date )
                {
                    validateInput = true;
                    //lbCheckInDateValidation.Text = "";
                }
                else
                {
                    validateInput = false;
                    // lbCheckInDateValidation.Text = "Wrong Date!Please Choose the Correct Date";
                    MessageBox.Show("Wrong Date!Please Choose the Correct Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbRoomNumber_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbRoomNumber.SelectedItem != null)
            {
                validateInput = true;
                lbRoomNumberValidation.Text = "";
                DataRowView selectedRow = (DataRowView)cbRoomNumber.SelectedItem;
                selectedRoomNo = selectedRow["room_no"].ToString();
                selectedRoomId = int.Parse(selectedRow["room_id"].ToString());
               // MessageBox.Show("id: " + selectedRoomId + " and room no: " + selectedRoomNo);
            }
        }

        private void cbRoomNumber_TextChanged(object sender, EventArgs e)
        {
            if (selectedRoomNo == cbRoomNumber.Text.ToString())
            {
                validateInput = true;
                //lbRoomNumberValidation.Text = "";
            }
            else
            {
                validateInput = false;
                //lbRoomNumberValidation.Text = "Choose the correct room number form drop down!";
                MessageBox.Show("Wrong Date!Please Choose the Correct Date","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbGuestNrc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbGuestNrc.SelectedItem != null)
            {
                validateInput = true;
                lbGuestNrcValidation.Text = "";
                DataRowView selectedRow = (DataRowView)cbGuestNrc.SelectedItem;
                selectedGuestName = selectedRow["full_name"].ToString();
                selectedGuestNrc = selectedRow["nrc_number"].ToString();
                selectedGuestId = int.Parse(selectedRow["guest_id"].ToString());
               // MessageBox.Show("id: " + selectedRoomId + " and room no: " + selectedRoomNo);
            }
        }

        private void cbGuestName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbGuestName.SelectedItem != null)
            {
                validateInput = true;
                lbGuestNameValidation.Text = "";
                DataRowView selectedRow = (DataRowView)cbGuestName.SelectedItem;
                selectedGuestName = selectedRow["full_name"].ToString();
                selectedGuestNrc = selectedRow["nrc_number"].ToString();
                selectedGuestId = int.Parse(selectedRow["guest_id"].ToString());
                // MessageBox.Show("id: " + selectedRoomId + " and room no: " + selectedRoomNo);
            }
        }

        private void cbGuestName_TextChanged(object sender, EventArgs e)
        {
            if (selectedGuestName == cbGuestName.Text.ToString())
            {
                validateInput = true;
                //lbGuestNameValidation.Text = "";
            }
            else
            {
                validateInput = false;
                lbGuestNameValidation.Text = "Choose the correct Guest form drop down!";
                MessageBox.Show("Choose the correct Guest form drop down!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbGuestNrc_TextChanged(object sender, EventArgs e)
        {
            if (selectedGuestNrc == cbGuestNrc.Text.ToString())
            {
                validateInput = true;
                //lbGuestNrcValidation.Text = "";
            }
            else
            {
                validateInput = false;
                //lbGuestNrcValidation.Text = "Choose the correct Nrc Number form drop down!";
                MessageBox.Show("Choose the correct Nrc Number form drop down!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(hdCheckInId.Text))
            {
                DialogResult result = MessageBox.Show("Are You Sure to Checkout", "Confirmation", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int id = Convert.ToInt32(hdCheckInId.Text.ToString());
                    decimal room_fees = 0;
                    int room_id = 0;
                    DateTime checkinDate = DateTime.MinValue;
                    DateTime checkoutDate = DateTime.MinValue;
                    DataTable dt = checkInService.Get(id);
                    foreach (DataRow row in dt.Rows)
                    {
                        room_id = Convert.ToInt32(row["room_id"]);
                        room_fees = Convert.ToDecimal(row["room_price"]);
                        checkinDate = Convert.ToDateTime(row["checkin_date"]);
                        checkoutDate = Convert.ToDateTime(row["checkout_date"]);
                    }
                    UCPayNow uCPayNow = new UCPayNow(id, room_id, room_fees, checkinDate, checkoutDate);
                    this.Controls.Clear();
                    this.Controls.Add(uCPayNow);
                }
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if (!string.IsNullOrEmpty(hdReservationId.Text.ToString()))
            {
                UCReservationList uCReservationList = new UCReservationList();
                this.Controls.Add(uCReservationList);
            }
            else
            {
                this.Controls.Add(uCCheckInList);
            }
        }
    }
}