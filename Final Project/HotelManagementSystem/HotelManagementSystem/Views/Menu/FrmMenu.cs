using HotelManagementSystem.Views.Reservation;
using HotelManagementSystem.Views.Guest;
using HotelManagementSystem.Views.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Views.Payment;
using HotelManagementSystem.Views.CheckIn;
using HotelManagementSystem.Views.Guest;
using HotelManagementSystem.Views.Room;
using HotelManagementSystem.Views.Admin;

namespace HotelManagementSystem.Views.Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDashBoard mainDashBoard = new MainDashBoard();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(mainDashBoard);
        }

        private void reservationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCReservationList uCReservationList = new UCReservationList();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCReservationList);
        }

        private void reservationAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCReservationAdd uCReservationAdd = new UCReservationAdd();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCReservationAdd);
        }

        private void cHECKADDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCCheckinAdd uCCheckInAdd = new UCCheckinAdd();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCCheckInAdd);
        }

        private void pAYMENTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPaymentHistory uCPaymentHistory = new UCPaymentHistory();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCPaymentHistory);
        }

        private void pAYMENTADDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPayNow uCPayNow = new UCPayNow();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCPayNow);
        }

        private void cHECKINLISTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UCCheckInList uCCheckInList = new UCCheckInList();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCCheckInList);
        }

        private void guestRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCGuestCRUD uCGuestCRUD = new UCGuestCRUD();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCGuestCRUD);
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCGuestList uCGuestList = new UCGuestList();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCGuestList);
        }

        private void eMPLOYEEREGISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCEmployee uCEmployee = new UCEmployee();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCEmployee);
        }

        private void eMPLOYEELISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCEmployeeList uCEmployeeList = new UCEmployeeList();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCEmployeeList);
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCRoomCrud uCRoomCrud = new UCRoomCrud();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCRoomCrud);
        }

        private void roomListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCRoomList uCRoomList=new UCRoomList();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCRoomList);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            UCAdmin uCAdmin = new UCAdmin();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCAdmin);
            mainMenu.Visible = false;
            btnLogout.Visible = false;
        }
        public void LoginSuccess()
        {
            MainDashBoard mainDashBoard = new MainDashBoard();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(mainDashBoard);
            mainMenu.Visible = true;
            btnLogout.Visible = true;
        }

        private void pAYMENTLISTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UCPaymentHistory uCPaymentHistory = new UCPaymentHistory();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCPaymentHistory);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UCAdmin uCAdmin = new UCAdmin();
                pnMain.Controls.Clear();
                pnMain.Controls.Add(uCAdmin);
                mainMenu.Visible = false;
                btnLogout.Visible = false;
            }
        }
    }
}
