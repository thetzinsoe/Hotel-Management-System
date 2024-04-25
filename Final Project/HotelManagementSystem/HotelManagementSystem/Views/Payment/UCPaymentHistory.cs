using HotelManagementSystem.Services.Guest;
using HotelManagementSystem.Services.Payment;
using HotelManagementSystem.Views.Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Views.Payment
{
    public partial class UCPaymentHistory : UserControl
    {
        int pageSize = 10;
        int currentPageIndex = 1;
        int totalPage = 0;
        PaymentService paymentService = new PaymentService();
        public UCPaymentHistory()
        {
            InitializeComponent();
        }

        private void UCPaymentHistory_Load(object sender, EventArgs e)
        {
            LoadPayment();
        }

        private void LoadPayment()
        {
            int offset = (currentPageIndex-1)*pageSize;
            DataTable dt = paymentService.GetWithPagination(offset, pageSize);
            DataTable dt1 = paymentService.GetAll();
            int rowCount = dt1.Rows.Count;
            totalPage = rowCount / pageSize;
            if (rowCount % pageSize > 0)
            {
                totalPage += 1;
            }
            lblPageNo.Text = $"Page 1 of {totalPage}";
            dgvPaymentHistory.AutoGenerateColumns = false;
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

        private void btn3xPrevious_Click_1(object sender, EventArgs e)
        {
            int prevPageIndex = this.currentPageIndex - 3;
            if (prevPageIndex > 1)
            {
                this.currentPageIndex = prevPageIndex;
            }
            else
            {
                this.currentPageIndex = 1;
            }
            LoadPayment();
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            if (this.currentPageIndex > 1)
            {
                this.currentPageIndex--;
                LoadPayment();
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (this.currentPageIndex < totalPage)
            {
                this.currentPageIndex++;
                LoadPayment();
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btn3xNext_Click_1(object sender, EventArgs e)
        {
            int nextPageIndex = this.currentPageIndex + 3;
            if (nextPageIndex < totalPage)
            {
                this.currentPageIndex = nextPageIndex;
            }
            else
            {
                this.currentPageIndex = totalPage;
            }
            LoadPayment();
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }
    }
}
