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
using HotelManagementSystem.Services.Reservation;
using HotelManagementSystem.Views.Payment;
using HotelManagementSystem.Views.Reservation;

namespace HotelManagementSystem.Views.CheckIn
{
    public partial class UCCheckInList : UserControl
    {
        int pageSize = 2;
        int currentPageIndex = 1;
        int totalPage = 0;
        CheckInService checkInService = new CheckInService();
        public UCCheckInList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCheckIn.Columns["checkout"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure to Checkout?", "Confirmation", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvCheckIn.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    decimal room_fees = 0;
                    int room_id = 0;
                    DateTime checkinDate = DateTime.MinValue;
                    DateTime checkoutDate = DateTime.MinValue;
                    DataTable dt = checkInService.Get(id);
                    foreach (DataRow row in dt.Rows)
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

            if (e.ColumnIndex == dgvCheckIn.Columns["Id"].Index && e.RowIndex >= 0)
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
            LoadCheckin();
            //DataTable dt1 = checkInService.GetAll();
            //dgvCheckIn.AutoGenerateColumns = false;
            //dgvCheckIn.DataSource = dt1;
        }

        private void LoadCheckin()
        {
            int offset = (currentPageIndex - 1) * pageSize;
            DataTable dt = checkInService.GetWithPagination(offset, pageSize);
            DataTable dt1 = checkInService.GetAll();
            int rowCount = dt1.Rows.Count;
            totalPage = rowCount / pageSize;
            if (rowCount % pageSize > 0)
            {
                totalPage += 1;
            }
            lblPageNo.Text = $"Page 1 of {totalPage}";
            dgvCheckIn.AutoGenerateColumns = false;
            dgvCheckIn.DataSource = dt;
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
            LoadCheckin();
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex > 1)
            {
                this.currentPageIndex--;
                LoadCheckin();
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex < totalPage)
            {
                this.currentPageIndex++;
                LoadCheckin();
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
            LoadCheckin();
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        //private void txtSearchBox_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(txtSearchBox)
        //        {
        //            DataTable dt = checkInService.GetWithPagination(currentPageIndex, pageSize);
        //            DataTable dt1 = checkInService.GetAll();
        //            int rowCount = dt1.Rows.Count;
        //            totalPage = rowCount / pageSize;
        //            if (rowCount % pageSize > 0)
        //            {
        //                totalPage += 1;
        //            }
        //            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        //            dgvCheckIn.AutoGenerateColumns = false;
        //            dgvCheckIn.DataSource = dt;
        //        }
        //        else
        //        {
        //            LoadCheckin();
        //        }
        //    } catch (Exception err)
        //    {
        //        MessageBox.Show(err.Message);
        //    }
        //}


        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchValue.Text.Length > 0)
            {
                if (cbSearchType.SelectedIndex == 0 || cbSearchType.SelectedIndex == -1)
                {
                    DataTable dt = checkInService.Search(0, txtSearchValue.Text.Trim());
                    lblPageNo.Text = $"Page 1 of 1";
                    dgvCheckIn.AutoGenerateColumns = false;
                    dgvCheckIn.DataSource = dt;
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    DataTable dt = checkInService.Search(1, txtSearchValue.Text.Trim());
                    lblPageNo.Text = $"Page 1 of 1";
                    dgvCheckIn.AutoGenerateColumns = false;
                    dgvCheckIn.DataSource = dt;
                }
            }
            else
            {
                LoadCheckin();
            }
        }
    }
}
