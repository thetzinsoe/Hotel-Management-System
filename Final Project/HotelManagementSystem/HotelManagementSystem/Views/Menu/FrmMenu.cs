using HotelManagementSystem.Views.Reservation;
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
            UCDashboard uCDashboard = new UCDashboard();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCDashboard);
        }

        private void rESERVATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

        private void cHECKINLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCCheckInList uCCheckInList = new UCCheckInList();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCCheckInList);
        }

        private void pAYMENTHISTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPaymentHistory uCPaymentHistory = new UCPaymentHistory();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCPaymentHistory);
        }
    }
}
