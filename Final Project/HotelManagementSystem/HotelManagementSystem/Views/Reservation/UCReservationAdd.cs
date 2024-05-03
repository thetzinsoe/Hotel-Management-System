using HotelManagementSystem.Entities.Reservation;
using HotelManagementSystem.Services.Employee;
using HotelManagementSystem.Services.Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem.Views.Reservation
{
    public partial class UCReservationAdd : UserControl
    {
        bool validateInput = false;
        private string selectedRoomNo = string.Empty;
        private int selectedRoomId = 0;
        DateTime checkin_date = DateTime.MinValue;
        DateTime checkout_date = DateTime.MinValue;
        DateTime oldcheckout_date = DateTime.MinValue;
        DateTime oldcheckin_date = DateTime.MinValue;
        int oldRoomId = 0;
        string oldRoomNo = string.Empty;
        public string ID
        { set { hdReservationId.Text = value; } }
        UCReservationList ucReservationList = new UCReservationList();
        ReservationService reservationService = new ReservationService();

        public UCReservationAdd()
        {
            InitializeComponent();
            dtpCheckInDate.MaxDate = DateTime.Today.AddMonths(1);
            dtpCheckInDate.MinDate = DateTime.Today;
            dtpCheckOutDate.MinDate = DateTime.Today;
            dtpCheckOutDate.MaxDate = DateTime.Today.AddMonths(7);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) || txtFullName.TextLength <= 4)
            {
                validateInput = false;
                MessageBox.Show("Please fill Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                validateInput = true;
            }


            if (string.IsNullOrEmpty(txtPhoneNumber.Text) || txtPhoneNumber.TextLength <= 7)
            {
                validateInput = false;
                MessageBox.Show("Please fill PhoneNumber", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                validateInput = true;
            }


            if (string.IsNullOrEmpty(hdReservationId.Text))
            {
                if (selectedRoomNo == cbRoomNo.Text && cbRoomNo.SelectedIndex >= 0)
                {
                    validateInput = true;
                }
                else
                {
                    validateInput = false;
                    MessageBox.Show("Please select one room!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (dtpCheckInDate.Value.Date > dtpCheckOutDate.Value.Date || dtpCheckInDate.Value.Date < DateTime.Today)
            {
                validateInput = false;
                MessageBox.Show("Checkin date must earlier than Checkout and not earlier than today date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ClearData()
        {
            selectedRoomNo = string.Empty;
            selectedRoomId = 0;
            checkin_date = DateTime.MinValue;
            checkout_date = DateTime.MinValue;
            oldcheckout_date = DateTime.MinValue;
            oldcheckin_date = DateTime.MinValue;
            oldRoomId = 0;
            oldRoomNo = string.Empty;
        }

        private void AddorUpdate()
        {
            ReservationService reservationService = new ReservationService();
            ReservationEntity reservationEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(hdReservationId.Text))
            {
                success = reservationService.Insert(reservationEntity);
                bool roomUp = reservationService.RoomUpdate(selectedRoomId, 1);
                if (success && roomUp)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    this.Controls.Clear();
                    this.Controls.Add(ucReservationList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Reservation Adding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (oldRoomId != selectedRoomId)
                {
                    DataTable dt = reservationService.haveRoom(oldRoomId);
                    if (dt.Rows.Count == 1)
                    {
                        bool remove = reservationService.RoomUpdate(oldRoomId, 0);
                        if (!remove)
                        {
                            MessageBox.Show("Error in changing for that room is avilable", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    bool add = reservationService.RoomUpdate(selectedRoomId, 1);
                    if (!add)
                    {
                        MessageBox.Show("Error in changing for that room is not avilable", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                success = reservationService.Update(reservationEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    this.Controls.Clear();
                    this.Controls.Add(ucReservationList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Updating Reservation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private ReservationEntity CreateData()
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
            reservationEntity.customer_name = txtFullName.Text.Trim();
            reservationEntity.customer_phoneNo = txtPhoneNumber.Text.Trim();
            return reservationEntity;
        }


        private void BtnState()
        {
            if (!string.IsNullOrEmpty(hdReservationId.Text))
            {
                lbTitle.Text = "RESERVATION UPDATE";
                btnBack.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Text = "Update";
            }
            else
            {
                lbTitle.Text = "RESERVATION ADD";
                btnBack.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Text = "Add";
            }
        }

        private void UCReservationAdd_Load(object sender, EventArgs e)
        {
            Load_room(dtpCheckInDate.Value.Date, dtpCheckOutDate.Value.Date);
            BtnState();
            BindData();
        }

        private void Load_room(DateTime checkin, DateTime checkout)
        {
            try
            {
                DataTable dt = reservationService.GetRoomWithDate(checkin.Date, checkout.Date);
                if (dt == null)
                {
                    validateInput = false;
                    MessageBox.Show("Every rooms are not avilable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cbRoomNo.DataSource = dt;
                cbRoomNo.DisplayMember = "room_no";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindData()
        {
            try
            {
                if (!String.IsNullOrEmpty(hdReservationId.Text))
                {
                    DataTable dt = reservationService.Get(Convert.ToInt32(hdReservationId.Text));

                    if (dt.Rows.Count > 0)
                    {
                        txtFullName.Text = dt.Rows[0]["customer_name"].ToString();
                        txtPhoneNumber.Text = dt.Rows[0]["customer_phoneNo"].ToString();

                        dtpCheckInDate.Text = dt.Rows[0]["checkin_date"].ToString();
                        checkin_date = Convert.ToDateTime(dt.Rows[0]["checkin_date"].ToString());
                        DateTime tempCheckInDate = Convert.ToDateTime(dt.Rows[0]["checkin_date"]);
                        oldcheckin_date = tempCheckInDate.AddDays(-1);

                        dtpCheckOutDate.Text = dt.Rows[0]["checkout_date"].ToString();
                        checkout_date = Convert.ToDateTime(dt.Rows[0]["checkout_date"].ToString());
                        DateTime tempCheckOutDate = Convert.ToDateTime(dt.Rows[0]["checkout_date"]);
                        oldcheckout_date = tempCheckOutDate.AddDays(1);

                        selectedRoomId = int.Parse(dt.Rows[0]["room_id"].ToString());
                        oldRoomId = int.Parse(dt.Rows[0]["room_id"].ToString());
                        selectedRoomNo = dt.Rows[0]["room_number"].ToString();
                        oldRoomNo = dt.Rows[0]["room_number"].ToString();
                        cbRoomNo.Text = selectedRoomNo;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(ucReservationList);
        }

        private void cbRoomNo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hdReservationId.Text) && dtpCheckInDate.Value.Date == checkin_date.Date && dtpCheckOutDate.Value.Date == checkout_date.Date)
            {
                cbRoomNo.Text = oldRoomNo;
                selectedRoomId = oldRoomId;
            }
            if (cbRoomNo.SelectedItem != null)
            {
                validateInput = true;
                DataRowView selectedRow = (DataRowView)cbRoomNo.SelectedItem;
                selectedRoomNo = selectedRow["room_no"].ToString();
                selectedRoomId = int.Parse(selectedRow["room_id"].ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(hdReservationId.Text))
            {
                DataTable dt = reservationService.haveRoom(selectedRoomId);
                bool upRoom = true;
                if (dt.Rows.Count == 1)
                {
                    upRoom = reservationService.RoomUpdate(selectedRoomId, 0);
                }
                bool success = reservationService.Delete(int.Parse(hdReservationId.Text));
                if (success && upRoom)
                {
                    MessageBox.Show("Reservation Delete Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Controls.Clear();
                    this.Controls.Add(ucReservationList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Deleting Reservation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hdReservationId.Text))
            {
                Load_room(dtpCheckInDate.Value.Date, dtpCheckOutDate.Value.Date);
            }
            else
            {
                if (checkin_date != dtpCheckInDate.Value && checkin_date != DateTime.MinValue)
                {
                    if (dtpCheckInDate.Value.Date > oldcheckin_date.Date && dtpCheckInDate.Value.Date <= checkout_date.Date)
                    {
                        cbRoomNo.Text = oldRoomNo;
                        selectedRoomId = oldRoomId;
                    }
                    else if (dtpCheckOutDate.Value.Date == checkout_date.Date)
                    {
                        Load_room(dtpCheckInDate.Value.Date, oldcheckin_date.Date);
                    }
                    else
                    {
                        Load_room(dtpCheckInDate.Value.Date, dtpCheckOutDate.Value.Date);
                    }
                }
            }
        }

        private void dtpCheckInDate_CloseUp(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hdReservationId.Text) && dtpCheckInDate.Value.Date == checkin_date.Date && dtpCheckOutDate.Value.Date <= checkout_date.Date)
            {
                cbRoomNo.Text = oldRoomNo;
                selectedRoomId = oldRoomId;
            }
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hdReservationId.Text))
            {
                Load_room(dtpCheckInDate.Value, dtpCheckOutDate.Value);
            }
            else
            {
                if (checkout_date != dtpCheckOutDate.Value && checkout_date != DateTime.MinValue)
                {
                    if (oldcheckout_date.Date > dtpCheckOutDate.Value.Date && dtpCheckInDate.Value.Date >= checkin_date.Date)
                    {
                        cbRoomNo.Text = oldRoomNo;
                        selectedRoomId = oldRoomId;
                    }
                    else if (dtpCheckInDate.Value.Date == checkin_date.Date)
                    {
                        Load_room(oldcheckout_date, dtpCheckOutDate.Value.Date);
                    }
                    else
                    {
                        Load_room(dtpCheckInDate.Value.Date, dtpCheckOutDate.Value.Date);
                    }
                }
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
            if (!string.IsNullOrEmpty(hdReservationId.Text) && dtpCheckInDate.Value.Date >= checkin_date.Date && dtpCheckOutDate.Value.Date == checkout_date.Date)
            {
                cbRoomNo.Text = oldRoomNo;
                selectedRoomId = oldRoomId;
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            bool containsDigit = txtFullName.Text.Any(c => !char.IsLetter(c) && !IsBurmeseCharacter(c) && c != ' ');

            if (containsDigit)
            {
                validateInput = false;
                MessageBox.Show("Please Enter valid Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                validateInput = true;
            }
        }
        private bool IsBurmeseCharacter(char c)
        {
            return (c >= '\u1000' && c <= '\u109F' || c == ' ');
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                bool isEnglishDigit = phoneNumber.All(c => char.IsDigit(c) || c == ' ');
                bool isBurmeseDigit = phoneNumber.All(c => IsBurmeseDigit(c));

                if (!(isEnglishDigit || isBurmeseDigit))
                {
                    validateInput = false;
                    MessageBox.Show("Please enter valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    validateInput = true;
                }
            }
        }

        // Function to check if a character is a Burmese digit
        private bool IsBurmeseDigit(char c)
        {
            return (c >= '\u1040' && c <= '\u1049' || c == ' ');
        }

        private void cbRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }
}
