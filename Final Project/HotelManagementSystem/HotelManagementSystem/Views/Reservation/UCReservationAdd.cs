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
        public string ID
        { set { hdReservationId.Text = value; } }
        UCReservationList ucReservationList = new UCReservationList();
        ReservationService reservationService = new ReservationService();
        
        public UCReservationAdd()
        {
            InitializeComponent();
            dtpCheckInDate.MinDate = DateTime.Today;
            dtpCheckInDate.MaxDate = DateTime.Today.AddMonths(1);
            dtpCheckOutDate.MinDate = DateTime.Today;
            dtpCheckOutDate.MaxDate = DateTime.Today.AddMonths(7);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFullName.Text)) 
            {
                validateInput = false;
                lbFullNameValidation.Text = "Please fill Name!";
            }
            else
            {
                validateInput = true;
                lbFullNameValidation.Text = "";
            }


            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                validateInput = false;
                lbPhoneNumberValidation.Text = "Please fill PhoneNumber";
            }
            else
            {
                validateInput = true;
                lbPhoneNumberValidation.Text = "";
            }

            if (cbRoomNo.SelectedIndex>=0)
            {
                validateInput = true;
                lbRoomNoValidation.Text = "";
            }
            else
            {
                validateInput = false;
                lbRoomNoValidation.Text = "Please Select Room!";
            }


            if (validateInput)
            {
                AddorUpdate();
            }
            else
            {
                MessageBox.Show("Some error occour! Please check the input value");
            }
            //MessageBox.Show(selectedRoomId + "    " + selectedRoomNo+ "   "+cbRoomNo.Text.ToString());
        }

        private void AddorUpdate()
        {
            ReservationService reservationService = new ReservationService();
            ReservationEntity reservationEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(hdReservationId.Text))
            {
                success = reservationService.Insert(reservationEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                    this.Controls.Clear();
                    this.Controls.Add(ucReservationList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Reservation Adding!");
                }
            }
            else
            {
                success = reservationService.Update(reservationEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                    this.Controls.Clear();
                    this.Controls.Add(ucReservationList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Updating Reservation!");
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
            reservationEntity.customer_name = txtFullName.Text;
            reservationEntity.customer_phoneNo = txtPhoneNumber.Text;
            return reservationEntity;
        }


        private void BtnState()
        {
            if (!string.IsNullOrEmpty(hdReservationId.Text))
            {
                btnBack.Enabled = true;
                btnDelete.Enabled=true;
                btnAdd.Text = "Update";
            }
            else
            {
                btnBack.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Text = "Add";
            }
        }

        private void UCReservationAdd_Load(object sender, EventArgs e)
        {            
            try
            {
                DataTable dt = reservationService.GetAllRoom();
                cbRoomNo.DataSource = dt;
                cbRoomNo.DisplayMember = "room_no";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            BtnState();
            BindData();
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
                        cbRoomNo.Text = dt.Rows[0]["room_number"].ToString();
                        dtpCheckInDate.Text = dt.Rows[0]["checkin_date"].ToString();
                        dtpCheckOutDate.Text = dt.Rows[0]["checkout_date"].ToString();
                    }
                }
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(ucReservationList);
        }

        private void cbRoomNo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbRoomNo.SelectedItem != null)
            {
                validateInput = true;
                lbRoomNoValidation.Text = "";
                DataRowView selectedRow = (DataRowView)cbRoomNo.SelectedItem;
                selectedRoomNo = selectedRow["room_no"].ToString();
                selectedRoomId = int.Parse(selectedRow["room_id"].ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(hdReservationId.Text))
            {
                bool success = reservationService.Delete(int.Parse(hdReservationId.Text));
                if (success)
                {
                    MessageBox.Show("Reservation Delete Success!");
                    this.Controls.Clear();
                    this.Controls.Add(ucReservationList);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Deleting Reservation!");
                }
            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpCheckInDate.Checked)
            {
                if(dtpCheckInDate.Value >= DateTime.Now.Date)
                {
                    validateInput = true;
                    lbCheckInDateValidation.Text = "";
                }
                else
                {
                    validateInput = false;
                    lbCheckInDateValidation.Text = "Wrong Date!Please Choose the Correct Date";
                }
            }
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpCheckOutDate.Value >= DateTime.Now.Date && dtpCheckOutDate.Value >= dtpCheckInDate.Value)
            {
                validateInput = true;
                lbCheckOutValidation.Text = "";
            }
            else
            {
                validateInput = false;
                lbCheckOutValidation.Text="Wrong Date! Please choose the correct date.";
            }
        }

        private void cbRoomNo_TextChanged(object sender, EventArgs e)
        {
            if (selectedRoomNo == cbRoomNo.Text.ToString())
            {
                validateInput = true;
                lbRoomNoValidation.Text = "";
            }
            else
            {
                validateInput = false;
                lbRoomNoValidation.Text = "Choose the correct room number form drop down!";
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            bool containsDigit = txtFullName.Text.Any(c => !char.IsLetter(c) && !IsBurmeseCharacter(c));

            if (containsDigit)
            {
                validateInput = false;
                lbFullNameValidation.Text = "Please Enter valid Name!";
            }
            else
            {
                validateInput = true;
                lbFullNameValidation.Text = "";
            }
        }
        private bool IsBurmeseCharacter(char c)
        {
            return (c >= '\u1000' && c <= '\u109F');
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                bool isEnglishDigit = phoneNumber.All(c => char.IsDigit(c));
                bool isBurmeseDigit = phoneNumber.All(c => IsBurmeseDigit(c));

                if (!(isEnglishDigit || isBurmeseDigit))
                {
                    validateInput = false;
                    lbPhoneNumberValidation.Text = "Please enter valid phone number";
                }
                else
                {
                    validateInput = true;
                    lbPhoneNumberValidation.Text = "";
                }
            }
        }

        // Function to check if a character is a Burmese digit
        private bool IsBurmeseDigit(char c)
        {
            return (c >= '\u1040' && c <= '\u1049');
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
