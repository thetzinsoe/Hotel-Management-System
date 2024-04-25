using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Entities.Admin;
using HotelManagementSystem.Entities.CheckIn;
using HotelManagementSystem.Entities.Employee;
using HotelManagementSystem.Services.Admin;
using HotelManagementSystem.Services.Employee;

namespace HotelManagementSystem.Views.Admin
{
    public partial class UCAdminSignUp : UserControl
    {
        AdminEntity adminEntity=new AdminEntity();
        AdminService adminService = new AdminService();
        public string ID
        { set { txtadminID.Text = value; } }
        public UCAdminSignUp()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidInput())
            {
                return;
            }
            adminRegister();
        }

        private void adminRegister()
        {
            AdminEntity adminEntity = CreateData();
            bool success = false;
            if (String.IsNullOrEmpty(txtadminID.Text))
            {
                success = adminService.InsertAdmin(adminEntity);
                if (success)
                {
                    MessageBox.Show("Save success", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error saving", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private AdminEntity CreateData()
        {
            if (!String.IsNullOrEmpty(txtadminID.Text))
            {
                adminEntity.UserId = Convert.ToInt32(txtadminID.Text);
            }
            adminEntity.Username = txtusername.Text;
            adminEntity.Password = txtpassword.Text;
            adminEntity.CreatedDate = DateTime.Now;
            adminEntity.IsDeleted = false;
            adminEntity.Role = "admin";
            adminEntity.UpdatedDate = DateTime.Now;
            return adminEntity;
        }

        private bool ValidInput()
        {
            string username=txtusername.Text, password=txtpassword.Text,validpass=txtvalidpass.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Enter username to register");
            }
            else if (!username.Any(char.IsLetter))
            {
                MessageBox.Show("Username Should be valid letter(up to 10 character!)");
            }
            else if (!username.Any(char.IsDigit))
            {
                MessageBox.Show("username should include at least 1 digit!");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter a vaild password");
            }
            else if (!password.Any(char.IsLetter))
            {
                MessageBox.Show("Password should at least contain 1 letter");
            }
            else if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password should at least has 1 digit!");
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password should at least has 1 upper letter");
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Password should at least be 8 characters long");
            }
            else if (string.IsNullOrWhiteSpace(validpass))
            {
                MessageBox.Show("Enter to confirm password!");
            }
            else if (validpass != password)
            {
                MessageBox.Show("Password not matching!");
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtvalidpass.Text = string.Empty;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                txtpassword.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtpassword.PasswordChar = '*';
                btnShow.Text = "Show";
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UCAdmin uCAdmin = new UCAdmin();
            this.Controls.Clear();
            this.Controls.Add(uCAdmin);
        }
    }
}
