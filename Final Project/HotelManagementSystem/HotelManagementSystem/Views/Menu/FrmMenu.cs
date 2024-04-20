using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Views.Admin;

namespace HotelManagementSystem.Views.Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCAdmin adminLogin = new UCAdmin();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(adminLogin);
            
        }
    }
}
