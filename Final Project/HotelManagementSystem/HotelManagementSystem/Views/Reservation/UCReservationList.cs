using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Services.Reservation;
using HotelManagementSystem.Views.CheckIn;

namespace HotelManagementSystem.Views.Reservation
{
    public partial class UCReservationList : UserControl
    {
        ReservationService reservationService = new ReservationService();
        public UCReservationList()
        {
            InitializeComponent();
        }

        private void UCReservation_Load(object sender, EventArgs e)
        {
            DataTable dt = reservationService.GetAll();
            dgvReservation.AutoGenerateColumns = false;
            dgvReservation.DataSource = dt;
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvReservation.Columns["checkin"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvReservation.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["reservation_id"].Value);
                    //MessageBox.Show("id : " + id);
                    UCCheckinAdd uCCheckinAdd = new UCCheckinAdd();
                    uCCheckinAdd.RvId = id.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(uCCheckinAdd);
                }

                int reservationId = Convert.ToInt32(dgvReservation.Rows[e.RowIndex].Cells["reservation_id"].Value);
                if (e.ColumnIndex == dgvReservation.Columns["reservation_id"].Index)
                {
                    UCReservationAdd uCReservationAdd = new UCReservationAdd();
                    uCReservationAdd.ID = reservationId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(uCReservationAdd);
                }
            }  
        }
    }
}
