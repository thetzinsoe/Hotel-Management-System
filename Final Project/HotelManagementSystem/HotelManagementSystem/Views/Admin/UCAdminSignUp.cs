using HotelManagementSystem.Entities.Admin;
using HotelManagementSystem.Services.Admin;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagementSystem.Views.Admin
{
    public partial class UCAdminSignUp : UserControl
    {
        AdminEntity adminEntity = new AdminEntity();
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
                    MessageBox.Show("Register success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UCAdmin uCAdmin = new UCAdmin();
                    this.Controls.Clear();
                    this.Controls.Add(uCAdmin);
                }
                else
                {
                    MessageBox.Show("Error registering", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private AdminEntity CreateData()
        {
            if (!String.IsNullOrEmpty(txtadminID.Text))
            {
                adminEntity.user_id = Convert.ToInt32(txtadminID.Text);
            }
            adminEntity.Username = txtusername.Text;
            adminEntity.Password = txtpassword.Text;
            adminEntity.CreatedDate = DateTime.Now;
            adminEntity.Role = 0;
            adminEntity.UpdatedDate = DateTime.Now;
            return adminEntity;
        }

        private bool ValidInput()
        {

            string username = txtusername.Text, password = txtpassword.Text, validpass = txtvalidpass.Text;
            try
            {
                DataTable dt = adminService.GetAdminByUsername(username);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username already in use!");
                    return false;
                }
            }
            catch
            {
                return true;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Enter username to register");
                return false;
            }
            if (!username.Any(char.IsLetter))
            {
                MessageBox.Show("Username Should be valid letter(up to 10 character!)");
                return false;
            }          
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter a vaild password");
                return false;
            }
            if (!password.Any(char.IsLetter))
            {
                MessageBox.Show("Password should at least contain 1 letter");
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password should at least has 1 digit!");
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password should at least has 1 upper letter");
                return false;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password should at least be 8 characters long");
                return false;
            }
            if (string.IsNullOrWhiteSpace(validpass))
            {
                MessageBox.Show("Enter to confirm password!");
                return false;
            }
            if (validpass != password)
            {
                MessageBox.Show("Password not matching!");
                return false;
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

        private void btnConfirmShow_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                txtvalidpass.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtvalidpass.PasswordChar = '*';
                btnShow.Text = "Show";
            }
        }
    }
}
