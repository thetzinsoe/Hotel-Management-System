using System;
using HotelManagementSystem.Entities.Guest;
using HotelManagementSystem.Services.Guest;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagementSystem.Views.Guest
{
    public partial class UCGuestCRUD : UserControl
    {
        public UCGuestCRUD()
        {
            InitializeComponent();
        }
        public UCGuestCRUD(string guestName, string guestPhone)
        {
            InitializeComponent();
            txtFullName.Text = guestName;
            txtPhoneNumber.Text = guestPhone;
        }

        public string ID
        { set { txtGuestId.Text = value; } }

        public string ReservationId
        {
            set { hdReservationId.Text = value; }
        }
        private void AddorUpdate()
        {
            UCGuestList uCGuestList = new UCGuestList();
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter Full Name (up to 100 characters).");
                return;
            }

            bool success = false;
            GuestService guestService = new GuestService();
            GuestEntity guestEntity = CreateData();
            if (String.IsNullOrEmpty(txtGuestId.Text))
            {
                success = guestService.Insert(guestEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error Saving", "Error", MessageBoxButtons.OK);
                }
            }

            else
            {
                success = guestService.Update(guestEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Error Updating", "Error", MessageBoxButtons.OK);
            }
            if (string.IsNullOrEmpty(hdReservationId.Text))
            {
                this.Controls.Clear();
                this.Controls.Add(uCGuestList);
            }
            else
            {
                uCGuestList.ReservationID=hdReservationId.Text;
                this.Controls.Clear();
                this.Controls.Add(uCGuestList);
            } 
        }

        private GuestEntity CreateData()
        {
            string gender = "";
            if (rdbOther.Checked)
                gender = "Other";
            else if (rdbMale.Checked)
                gender = "Male";
            else if (rdbFemale.Checked)
                gender = "Female";
            short genderValue = -1;
            if (gender == "Other")
            {
                genderValue = 0;
            }
            else if (gender == "Male")
            {
                genderValue = 1;
            }
            else if (gender == "Female")
            {
                genderValue = 2;
            }
            GuestEntity guestEntity = new GuestEntity(); ;
            if (!String.IsNullOrEmpty(txtGuestId.Text))
            {
                guestEntity.guestId = Convert.ToInt32(txtGuestId.Text);
            }
            guestEntity.fullName = txtFullName.Text;
            guestEntity.gender = genderValue;
            guestEntity.dob = dtpDob.Value;
            guestEntity.nationality = txtNationality.Text;
            guestEntity.nrcNumber = txtNRCNumber.Text;
            guestEntity.address = txtAddress.Text;
            guestEntity.phoneNumber = txtPhoneNumber.Text;

            return guestEntity;
        }

        private void BindData()
        {
            GuestService guestService = new GuestService();
            if (!String.IsNullOrEmpty(txtGuestId.Text))
            {
                DataTable dt = guestService.Get(Convert.ToInt32(txtGuestId.Text));
                if (dt.Rows.Count > 0)
                {
                    txtFullName.Text = dt.Rows[0]["full_name"].ToString();
                    txtPhoneNumber.Text = dt.Rows[0]["phone_number"].ToString();
                    txtNationality.Text = dt.Rows[0]["nationality"].ToString();
                    txtNRCNumber.Text = dt.Rows[0]["nrc_number"].ToString();
                    txtAddress.Text = dt.Rows[0]["address"].ToString();
                    dtpDob.Value = (DateTime)dt.Rows[0]["dob"];
                    int gendervalue = Convert.ToInt32(dt.Rows[0]["gender"]);
                    switch (gendervalue)
                    {
                        case 0:
                            rdbOther.Checked = true;
                            break;

                        case 1:
                            rdbMale.Checked = true;
                            break;
                        case 2:
                            rdbFemale.Checked = true;
                            break;
                        default:
                            MessageBox.Show("Error assigning gendervalue");
                            break;
                    }
                }
            }
        }

        private void BtnControl()
        {
            if (!String.IsNullOrEmpty(txtGuestId.Text))
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
        private void UCGuestCRUD_Load_1(object sender, EventArgs e)
        {
            dtpDob.MaxDate = DateTime.Today;
            dtpDob.Value = DateTime.Today;

            BindData();
            BtnControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!ValidateInput())
            {
                return;
            }
            AddorUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UCGuestList uCGuestList = new UCGuestList();
            int guestId = Convert.ToInt32(txtGuestId.Text);
            GuestService guestService = new GuestService();
            bool success = false;
            success = guestService.Delete(guestId);
            if (success)
            {
                MessageBox.Show("Delete Success");
                this.Controls.Clear();
                this.Controls.Add(uCGuestList);
            }
            else
            {
                MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFullName.Text.Length >= 100 && e.KeyChar != '\b')
            {
                MessageBox.Show("Maximun character limit reached (100).");
                e.Handled = true;
            }
        }

        private void txtNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNationality.Text.Length >= 50 && e.KeyChar != '\b')
            {
                MessageBox.Show("Maximun character limit reached (50).");
                e.Handled = true;
            }
        }

        private void txtNRCNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNRCNumber.Text.Length >= 50 && e.KeyChar != '\b')
            {
                MessageBox.Show("Maximun character limit reached (50).");
                e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddress.Text.Length >= 255 && e.KeyChar != '\b')
            {
                MessageBox.Show("Maximun character limit reached (255).");
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPhoneNumber.Text.Length >= 50 && e.KeyChar != '\b')
            {
                MessageBox.Show("Maximun character limit reached (50).");
                e.Handled = true;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Please enter Full Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int age = Convert.ToInt32(DateTime.Today.Year - dtpDob.Value.Year);
            if (dtpDob.Value.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                MessageBox.Show("You need to be above 18 years old", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtNationality.Text))
            {
                MessageBox.Show("Please enter Nationality.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtNRCNumber.Text))
            {
                MessageBox.Show("Please enter NRC Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter Phone Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            BtnControl();
        }
        private void ClearForm()
        {
            txtGuestId.Clear();
            txtFullName.Clear();
            txtNationality.Clear();
            dtpDob.Value = DateTime.Today;
            rdbOther.Checked = true;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtNRCNumber.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UCGuestList uCGuestList = new UCGuestList();
            this.Controls.Clear();
            this.Controls.Add(uCGuestList);
        }

        private void txtGuestId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
