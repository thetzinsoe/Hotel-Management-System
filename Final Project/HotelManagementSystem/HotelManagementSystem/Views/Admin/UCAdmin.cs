using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string username=txtusername.Text,password=txtpass.Text;
            Services.Admin.AdminService adminService = new Services.Admin.AdminService();
            Entities.Admin.AdminEntity adminEntity = new Entities.Admin.AdminEntity();
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
                DataTable dt = adminService.GetAdminByUsername(txtusername.Text);
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
                    }
                }
            }
        }
    }
}
