using HotelManagementSystem.Services.CheckIn;
using HotelManagementSystem.Views.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Views.CheckIn
{
    public partial class UCOldCheckinList : UserControl
    {
        int pageSize = 10;
        int currentPageIndex = 1;
        int totalPage = 0;
        public string ID
        { set { hdOldCheckinId.Text = value; } }

        CheckInService checkInService = new CheckInService();
       
        public UCOldCheckinList()
        {
            InitializeComponent();
            dgvOldCheckIn.EnableHeadersVisualStyles = false;
            dgvOldCheckIn.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
        }

        private void UCOldCheckinList_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hdOldCheckinId.Text))
            {
                cbSearchType.SelectedIndex = 2;
                txtSearchValue.Text = hdOldCheckinId.Text;
                DataTable dt = checkInService.SearchOld(2, hdOldCheckinId.Text.Trim());
                lblPageNo.Text = $"Page 1 of 1";
                dgvOldCheckIn.AutoGenerateColumns = false;
                if (dt.Rows.Count < pageSize)
                {
                    int blankRowCount = pageSize - dt.Rows.Count;
                    for (int i = 0; i < blankRowCount; i++)
                    {
                        DataRow newRow = dt.NewRow();
                        dt.Rows.Add(newRow);
                    }
                }
                dgvOldCheckIn.DataSource = dt;
                dgvOldCheckIn.Refresh();
            }
            else
            {
                LoadCheckin();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCPaymentHistory uCPaymentHistory = new UCPaymentHistory();
            this.Controls.Clear();
            this.Controls.Add(uCPaymentHistory);
        }


        private void LoadCheckin()
        {
            int offset = (currentPageIndex - 1) * pageSize;
            DataTable dt = checkInService.GetWithPaginationOld(offset, pageSize);
            DataTable dt1 = checkInService.GetAllOld();
            int rowCount = dt1.Rows.Count;
            totalPage = rowCount / pageSize;
            if (rowCount % pageSize > 0)
            {
                totalPage += 1;
            }
            lblPageNo.Text = $"Page 1 of {totalPage}";
            dgvOldCheckIn.AutoGenerateColumns = false;
            dgvOldCheckIn.DataSource = dt;
            dgvOldCheckIn.Refresh();
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

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchValue.Text.Length > 0)
            {
                if (cbSearchType.SelectedIndex == 0 || cbSearchType.SelectedIndex == -1)
                {
                    DataTable dt = checkInService.SearchOld(0, txtSearchValue.Text.Trim());
                    lblPageNo.Text = $"Page 1 of 1";
                    dgvOldCheckIn.AutoGenerateColumns = false;
                    dgvOldCheckIn.DataSource = dt;
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    DataTable dt = checkInService.SearchOld(1, txtSearchValue.Text.Trim());
                    lblPageNo.Text = $"Page 1 of 1";
                    dgvOldCheckIn.AutoGenerateColumns = false;
                    dgvOldCheckIn.DataSource = dt;
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    DataTable dt = checkInService.SearchOld(2, txtSearchValue.Text.Trim());
                    lblPageNo.Text = $"Page 1 of 1";
                    dgvOldCheckIn.AutoGenerateColumns = false;
                    dgvOldCheckIn.DataSource = dt;
                }
            }
            else
            {
                LoadCheckin();
            }
        }
    }
}
