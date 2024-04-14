using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Views.Reservation
{
    public partial class UCReservationAdd : UserControl
    {
        
        public UCReservationAdd()
        {
            InitializeComponent();
            dtpCheckInDate.MinDate = DateTime.Today;
            dtpCheckInDate.MaxDate = DateTime.Today.AddMonths(1);
            dtpCheckOutDate.MinDate = DateTime.Today;
            dtpCheckOutDate.MaxDate = DateTime.Today.AddMonths(7);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            cbRoomNo.Text = string.Empty;
            dtpCheckInDate.Text = DateTime.Now.ToString();
            dtpCheckOutDate.Text = DateTime.Now.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
