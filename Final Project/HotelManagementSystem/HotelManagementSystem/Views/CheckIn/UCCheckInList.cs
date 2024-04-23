using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Services.CheckIn;
using HotelManagementSystem.Views.Payment;
using HotelManagementSystem.Views.Reservation;

namespace HotelManagementSystem.Views.CheckIn
{
    public partial class UCCheckInList : UserControl
    {
        CheckInService checkInService = new CheckInService();
        public UCCheckInList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCheckIn.Columns["checkout"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure to Checkout", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvCheckIn.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    decimal room_fees = 0;
                    int room_id = 0;
                    DateTime checkinDate = DateTime.MinValue;
                    DateTime checkoutDate = DateTime.MinValue;
                    DataTable dt = checkInService.Get(id);
                    foreach(DataRow row in dt.Rows)
                    {
                        room_fees = Convert.ToDecimal(row["room_price"]);
                        room_id = Convert.ToInt32(row["room_id"]);
                        checkinDate = Convert.ToDateTime(row["checkin_date"]);
                        checkoutDate = Convert.ToDateTime(row["checkout_date"]);
                    }
                    UCPayNow uCPayNow = new UCPayNow(id, room_id, room_fees, checkinDate, checkoutDate);
                    this.Controls.Clear();
                    this.Controls.Add(uCPayNow);
                    // MessageBox.Show("id : " + id);
                }
            }

            if (e.ColumnIndex == dgvCheckIn.Columns["Id"].Index && e.RowIndex>=0)
            {
                int checkinId = Convert.ToInt32(dgvCheckIn.Rows[e.RowIndex].Cells["ID"].Value);
                UCCheckinAdd uCCheckInAdd = new UCCheckinAdd();
                uCCheckInAdd.ID = checkinId.ToString();
                this.Controls.Clear();
                this.Controls.Add(uCCheckInAdd);
            }
        }

        private void UCCheckInList_Load(object sender, EventArgs e)
        {
            DataTable dt = checkInService.GetAll();
            dgvCheckIn.AutoGenerateColumns = false;
            dgvCheckIn.DataSource = dt;
        }
    }
}
