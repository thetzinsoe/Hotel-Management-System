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
        private int oldRoomId = 0;
        private string oldRoomNumber = string.Empty;
        private string selectedGuestName = string.Empty;
        private string selectedGuestNrc = string.Empty;
        private int selectedGuestId = 0;
        DateTime oldCheckinDate = DateTime.MinValue;
        DateTime oldCheckoutDate = DateTime.MinValue;
        private string selectedPhone = string.Empty;
        private DateTime newCheckinDate = DateTime.MinValue;
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
            dtpCheckInDate.Value = DateTime.Today;
            dtpCheckOutDate.Value = DateTime.Today;
        }

        private void UCCheckinAdd_Load(object sender, EventArgs e)
        {
            cbRoomNumber.Focus();
            if (dtpCheckOutDate.Value.Date >= dtpCheckInDate.Value.Date)
            {
                validateInput = true;
                lbCheckOutValidation.Text = "";
            }
            else
            {
                validateInput = false;
                MessageBox.Show("Wrong Date! Please choose the correct date.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Load_Room(dtpCheckInDate.Value.Date,dtpCheckOutDate.Value.Date);
            BtnState();
            BindData();
        }

        private void ClearData()
        {
            selectedRoomNo = string.Empty;
            selectedRoomId = 0;
            oldRoomId = 0;
            oldRoomNumber = string.Empty;
            selectedGuestName = string.Empty;
            selectedGuestNrc = string.Empty;
            selectedGuestId = 0;
            oldCheckinDate = DateTime.MinValue;
            oldCheckoutDate = DateTime.MinValue;
            selectedPhone = string.Empty;
            newCheckinDate = DateTime.MinValue;
        }

        private void Load_Room(DateTime checkin, DateTime checkout)
        {
            try
            {
                DataTable dt = null;
                dt = reservationService.GetRoomWithDate(checkin.Date, checkout.Date);
                if (dt == null)
                {
                    validateInput = false;
                    MessageBox.Show("Every rooms are not avilable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cbRoomNumber.DataSource = dt;
                cbRoomNumber.DisplayMember = "room_no";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (selectedGuestName != cbGuestName.Text || selectedGuestId == 0)
            {
                validateInput = false;
                MessageBox.Show("You must need to choose one Guest to checkin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                validateInput = true;
            }

            if (string.IsNullOrEmpty(cbRoomNumber.Text) || selectedRoomId == 0 || selectedRoomNo != cbRoomNumber.Text)
            {
                validateInput = false;
                MessageBox.Show("You must need to choose one room to checkin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                validateInput = true;
            }

            if (selectedGuestNrc != cbGuestNrc.Text)
            {
                validateInput = false;
                MessageBox.Show("You must need to choose one valid Nrc to checkin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                validateInput = true;
            }

            if (string.IsNullOrEmpty(hdCheckInId.Text))
            {
                if(dtpCheckInDate.Value.Date >= DateTime.Today)
                {
                    validateInput = true;
                }
                else
                {
                    validateInput = false;
                    MessageBox.Show("Check in date must be equal or later than today date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (dtpCheckInDate.Value.Date<=dtpCheckOutDate.Value.Date)
            {
                validateInput = true;
            }
            else
            {
                validateInput = false;
                MessageBox.Show("Check in date must earlier than check out date and not earlier than today date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                   ReservationEntity reservationEntity = CreateReservationData();
                   bool resDel = reservationService.Update(reservationEntity);
                    if (!resDel)
                    {
                        MessageBox.Show("Cant add reservation!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    ReservationEntity reservationEntity = CreateReservationData();
                    bool resDel = reservationService.Insert(reservationEntity);
                    if (!resDel)
                    {
                        MessageBox.Show("Cant add reservation!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                success = checkInService.Insert(checkInEntity);
                bool roomOp = reservationService.RoomUpdate(selectedRoomId, 1);
                if (success && roomOp)
                {
                    ClearData();
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
                if (!string.IsNullOrEmpty(hdReservationId.Text))
                {
                    ReservationEntity reservationEntity = CreateReservationData();
                    bool resDel = reservationService.Update(reservationEntity);
                    if (!resDel)
                    {
                        MessageBox.Show("Cant add reservation!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                success = checkInService.Update(checkInEntity);
                if (success)
                {
                    ClearData();
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


        private ReservationEntity CreateReservationData()
        {
            ReservationEntity reservationEntity = new ReservationEntity();
            if (!String.IsNullOrEmpty(hdReservationId.Text))
            {
                reservationEntity.reservation_id = Convert.ToInt32(hdReservationId.Text);
            }
            reservationEntity.room_id = selectedRoomId;
            reservationEntity.room_number = selectedRoomNo;
            reservationEntity.checkin_date = dtpCheckInDate.Value.Date;
            reservationEntity.checkout_date = dtpCheckOutDate.Value.Date;
            reservationEntity.customer_name = selectedGuestName;
            reservationEntity.customer_phoneNo = selectedPhone;
            reservationEntity.is_deleted = 2;
            return reservationEntity;
        }


        private void BtnState()
        {
            if (!string.IsNullOrEmpty(hdCheckInId.Text))
            {
                lbTitle.Text = "UPDATE CHECKIN";
                btnCheckOut.Enabled = true;
                btnCheckIn.Text = "UPDATE";
            }
            else
            {
                lbTitle.Text = "ADD NEW CHECKIN";
                btnCheckOut.Enabled = false;
                btnCheckIn.Text = "CHECKIN";
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
                        oldRoomId = int.Parse(dt.Rows[0]["room_id"].ToString());
                        selectedRoomNo = dt.Rows[0]["room_no"].ToString();
                        oldRoomNumber = dt.Rows[0]["room_no"].ToString();
                        cbRoomNumber.Text = selectedRoomNo;
                        selectedPhone = dt.Rows[0]["phone_number"].ToString();
                        cbGuestNrc.Text = dt.Rows[0]["nrc_number"].ToString();
                        oldCheckinDate = Convert.ToDateTime(dt.Rows[0]["checkin_date"].ToString());
                        dtpCheckInDate.Text = dt.Rows[0]["checkin_date"].ToString();
                        oldCheckoutDate = Convert.ToDateTime(dt.Rows[0]["checkout_date"].ToString());
                        dtpCheckOutDate.Text = dt.Rows[0]["checkout_date"].ToString();
                        DateTime oldCheckOutDate = Convert.ToDateTime(dt.Rows[0]["checkout_date"]);
                        newCheckinDate = oldCheckOutDate.AddDays(1);
                    }

                    if (!string.IsNullOrEmpty(hdReservationId.Text))
                    {
                        int id = reservationService.FindReservationId(selectedRoomId, dtpCheckInDate.Value.Date, dtpCheckOutDate.Value.Date);
                        if (id <= 0)
                        {
                            MessageBox.Show("Reservation not Found","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            hdReservationId.Text = id.ToString();
                        }
                    }
                }
                else if(!string.IsNullOrEmpty(hdReservationId.Text)){
                    DataTable dt = reservationService.Get(Convert.ToInt32(hdReservationId.Text.ToString()));
                    if (dt.Rows.Count > 0)
                    {
                        selectedRoomId = int.Parse(dt.Rows[0]["room_id"].ToString());
                        selectedRoomNo = dt.Rows[0]["room_no"].ToString();
                        selectedPhone = dt.Rows[0]["customer_phoneNo"].ToString();
                        cbGuestNrc.Text = hdGuestNrc.Text;
                        cbRoomNumber.Text = dt.Rows[0]["room_no"].ToString();
                        dtpCheckInDate.Text = dt.Rows[0]["checkin_date"].ToString();
                        dtpCheckOutDate.Text = dt.Rows[0]["checkout_date"].ToString();
                    }
                }
                else if (string.IsNullOrEmpty(hdReservationId.Text))
                {                   
                    if (!string.IsNullOrEmpty(hdGuestNrc.Text))
                    {
                        cbGuestNrc.Text = hdGuestNrc.Text;
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
            if (!string.IsNullOrEmpty(hdCheckInId.Text))
            {
                if (newCheckinDate.Date > dtpCheckOutDate.Value.Date && dtpCheckInDate.Value.Date <= dtpCheckOutDate.Value.Date)
                {
                    cbRoomNumber.Text = oldRoomNumber;
                    selectedRoomId = oldRoomId;
                }
                else
                {
                    Load_Room(newCheckinDate, dtpCheckOutDate.Value.Date);
                }
            }
            else
            {
                Load_Room(dtpCheckInDate.Value.Date,dtpCheckOutDate.Value.Date);
            }

            if (dtpCheckOutDate.Value >= DateTime.Now.Date && dtpCheckOutDate.Value >= dtpCheckInDate.Value)
            {
                validateInput = true;
            }
            else
            {
                validateInput = false;
                MessageBox.Show("Checkout date equal or later than checkin date!", "Wrong Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpCheckOutDate_CloseUp(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hdCheckInId.Text) && dtpCheckOutDate.Value.Date == oldCheckoutDate.Date)
            {
                cbRoomNumber.Text = oldRoomNumber;
                selectedRoomId = oldRoomId;
            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckInDate.Enabled = false;
            if (dtpCheckInDate.Checked && String.IsNullOrEmpty(hdCheckInId.Text))
            {
                if (dtpCheckInDate.Value.Date >= DateTime.Now.Date && dtpCheckInDate.Value.Date<=dtpCheckOutDate.Value.Date)
                {
                    validateInput = true;
                }
                else
                {
                    validateInput = false;
                }
            }
        }

        private void cbRoomNumber_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hdCheckInId.Text) && dtpCheckInDate.Value.Date == oldCheckinDate.Date && dtpCheckOutDate.Value.Date == oldCheckoutDate.Date)
            {
                cbRoomNumber.Text = oldRoomNumber;
                selectedRoomId = oldRoomId;
            }
            if (cbRoomNumber.SelectedItem != null)
            {
                validateInput = true;
                lbRoomNumberValidation.Text = "";
                DataRowView selectedRow = (DataRowView)cbRoomNumber.SelectedItem;
                selectedRoomNo = selectedRow["room_no"].ToString();
                selectedRoomId = int.Parse(selectedRow["room_id"].ToString());
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
                selectedPhone = selectedRow["phone_number"].ToString();
                selectedGuestId = int.Parse(selectedRow["guest_id"].ToString());
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
            if (!string.IsNullOrEmpty(hdReservationId.Text.ToString()) && string.IsNullOrEmpty(hdCheckInId.Text))
            {
                UCReservationList uCReservationList = new UCReservationList();
                this.Controls.Add(uCReservationList);
            }
            else
            {
                this.Controls.Add(uCCheckInList);
            }
        }

        private void cbRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbGuestName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbGuestNrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}