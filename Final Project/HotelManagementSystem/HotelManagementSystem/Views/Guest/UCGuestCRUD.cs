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

        public string ID
        { set { txtGuestId.Text = value; } }

        private void UCGuestCRUD_Load(object sender, EventArgs e)
        {

        }

        private void AddorUpdate()
        {
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
                    MessageBox.Show("Error Saving","Error", MessageBoxButtons.OK);
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
            //this.Controls.Clear();
            //this.Controls.Add(uCShopList);
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
            guestEntity.dob = dateTimePicker1.Value;
            guestEntity.nationality = txtNationality.Text;
            guestEntity.nrcNumber = txtNRCNumber.Text;
            guestEntity.address = txtAddress.Text;
            guestEntity.phoneNumber = txtPhoneNumber.Text;

            return guestEntity;
        } 
    }
}
