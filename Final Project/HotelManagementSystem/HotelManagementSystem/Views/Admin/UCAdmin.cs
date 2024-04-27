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
using HotelManagementSystem.Services.Admin;
using HotelManagementSystem.Views;
using HotelManagementSystem.Views.Menu;

namespace HotelManagementSystem.Views.Admin
{
    public partial class UCAdmin : UserControl
    {
        public UCAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
            
        }

        private void Login()
        {
            string username = txtUsername.Text, password = txtPassword.Text;
            AdminService adminService = new AdminService();
            AdminEntity adminEntity = new AdminEntity();
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Enter valid username!");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter valid password!");
            }
            else
            {
                DataTable dt = adminService.GetAdminByUsername(txtUsername.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Username Does not Exist!");
                }
                else
                {
                    string validpass = dt.Rows[0][2].ToString();
                    if (password != validpass)
                    {
                        MessageBox.Show("Incorrect Password!");
                    }
                    else
                    {
                        MessageBox.Show("Login Successful!");
                        FrmMenu mainForm = this.ParentForm as FrmMenu;
                        mainForm.LoginSuccess();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShow.Text = "Show";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UCAdminSignUp uCAdminSignUp = new UCAdminSignUp();
            this.Controls.Clear();
            this.Controls.Add(uCAdminSignUp);
        }
    }
}
