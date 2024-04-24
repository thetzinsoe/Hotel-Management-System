using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Services.Payment;
using HotelManagementSystem.Services.Reservation;
using HotelManagementSystem.Views.CheckIn;
using HotelManagementSystem.Views.Guest;

namespace HotelManagementSystem.Views.Reservation
{
    public partial class UCReservationList : UserControl
    {
        int pageSize = 10;
        int currentPageIndex = 1;
        int totalPage = 0;
        ReservationService reservationService = new ReservationService();
        public UCReservationList()
        {
            InitializeComponent();
        }

        private void UCReservation_Load(object sender, EventArgs e)
        {
            LoadReservation();
        }

        private void LoadReservation()
        {
            int offset = (currentPageIndex - 1) * pageSize;
            DataTable dt = reservationService.GetWithPagination(offset, pageSize);
            DataTable dt1 = reservationService.GetAll();
            int rowCount = dt1.Rows.Count;
            totalPage = rowCount / pageSize;
            if (rowCount % pageSize > 0)
            {
                totalPage += 1;
            }
            lblPageNo.Text = $"Page 1 of {totalPage}";
            dgvReservation.AutoGenerateColumns = false;
            dgvReservation.DataSource = dt;
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvReservation.Columns["checkin"].Index && e.RowIndex >= 0)
                {
                   DialogResult result = MessageBox.Show("You need to check the guest is registered or create account for this guest!","Check!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DataGridViewRow selectedRow = dgvReservation.Rows[e.RowIndex];
                        int id = Convert.ToInt32(selectedRow.Cells["reservation_id"].Value);
                        DataTable dt = reservationService.Get(id);
                        string name = string.Empty;
                        string phone = string.Empty;
                        if (dt != null)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                name = row["customer_name"].ToString();
                                phone = row["customer_phoneNo"].ToString();
                            }
                        }
                        
                        UCGuestList uCGuestList = new UCGuestList(name,phone);
                        uCGuestList.ReservationID = id.ToString();
                        this.Controls.Clear();
                        this.Controls.Add(uCGuestList);
                    }
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

        private void btn3xPrevious_Click(object sender, EventArgs e)
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
            LoadReservation();
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex > 1)
            {
                this.currentPageIndex--;
                LoadReservation();
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex < totalPage)
            {
                this.currentPageIndex++;
                LoadReservation();
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btn3xNext_Click(object sender, EventArgs e)
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
            LoadReservation();
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            int offset = (currentPageIndex - 1) * pageSize;
            DataTable dt = reservationService.GetWithPagination(offset, pageSize,txtSearchValue.Text.Trim());
            DataTable dt1 = reservationService.GetAll();
            int rowCount = dt1.Rows.Count;
            totalPage = rowCount / pageSize;
            if (rowCount % pageSize > 0)
            {
                totalPage += 1;
            }
            lblPageNo.Text = $"Page 1 of {totalPage}";
            dgvReservation.AutoGenerateColumns = false;
            dgvReservation.DataSource = dt;
        }

        private void txtSearchValue_MouseClick(object sender, MouseEventArgs e)
        {
            currentPageIndex = 1;
            LoadReservation();
        }

    }
}
