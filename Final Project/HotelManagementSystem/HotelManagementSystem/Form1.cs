using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Views.Employee;
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

        private void guestListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCGuestList uCGuestList = new UCGuestList();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(uCGuestList);
        }

        private void employeeCRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCEmployee uCEmployee = new UCEmployee();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(uCEmployee);
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCEmployeeList uCEmployeeList = new UCEmployeeList();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(uCEmployeeList);
        }
    }
}
