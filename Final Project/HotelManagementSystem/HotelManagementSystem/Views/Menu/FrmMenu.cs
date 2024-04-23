﻿using HotelManagementSystem.Views.Reservation;
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
using HotelManagementSystem.Views.Room;

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

        private void newRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCRoomCRUD uCRoomCRUD = new UCRoomCRUD();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCRoomCRUD);
        }

        private void availableRoomListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCRoomList uCRoomList = new UCRoomList();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCRoomList);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            UCDashboard uCDashboard = new UCDashboard();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCDashboard);
        }
    }
}
