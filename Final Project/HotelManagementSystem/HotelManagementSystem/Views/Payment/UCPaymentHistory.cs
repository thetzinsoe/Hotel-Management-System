using HotelManagementSystem.Services.Payment;
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

namespace HotelManagementSystem.Views.Payment
{
    public partial class UCPaymentHistory : UserControl
    {
        PaymentService paymentService = new PaymentService();
        public UCPaymentHistory()
        {
            InitializeComponent();
        }

        private void UCPaymentHistory_Load(object sender, EventArgs e)
        {
            DataTable dt = paymentService.GetAll();
            dgvPaymentHistory.AutoGenerateColumns=false;
            dgvPaymentHistory.DataSource = dt;
        }

        private void dgvPaymentHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex >= 0)
            {
                int paymentId = Convert.ToInt32(dgvPaymentHistory.Rows[e.RowIndex].Cells["payment_id"].Value);
                if (e.ColumnIndex == dgvPaymentHistory.Columns["payment_id"].Index)
                {
                    UCPayNow uCPayNow = new UCPayNow();
                    uCPayNow.ID = paymentId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(uCPayNow);
                }
            }
        }
    }
}
