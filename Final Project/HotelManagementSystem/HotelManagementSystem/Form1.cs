using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Views.Guest;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guestCRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCGuestCRUD uCGuestCRUD = new UCGuestCRUD();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(uCGuestCRUD);
        }
    }
}
