using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Services.Room;

namespace HotelManagementSystem.Views.Room
{
    public partial class UCRoomList : UserControl
    {
        int pageSize = 10;
        int currentPageIndex = 1;
        int totalPage = 0;
        RoomService roomService = new RoomService();
        public UCRoomList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = roomService.SearchRoomsByType(txtSearch.Text);
            dgvRoomList.DataSource = dt;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex > 1)
            {
                this.currentPageIndex--;
                DataTable dt = roomService.GetPagedRooms(currentPageIndex, pageSize);
                this.dgvRoomList.DataSource = dt;
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex < totalPage)
            {
                this.currentPageIndex++;
                DataTable dt = roomService.GetPagedRooms(currentPageIndex, pageSize);
                this.dgvRoomList.DataSource = dt;
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.currentPageIndex = 1;
            DataTable dt = roomService.GetPagedRooms(currentPageIndex, pageSize);
            this.dgvRoomList.DataSource = dt;
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        private void btnLast_Click(object sender, EventArgs e)
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
            DataTable dt = roomService.GetPagedRooms(currentPageIndex, pageSize);
            this.dgvRoomList.DataSource = dt;
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        private void dgvRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UCRoomCrud uCRoomCRUD = new UCRoomCrud();
                //int roomid = Convert.ToInt32(dgvRoomList.Rows[e.RowIndex].Cells["RoomID"].Value);
                string roomnumber=dgvRoomList.Rows[e.RowIndex].Cells["RoomNumber"].Value.ToString();
                if (e.ColumnIndex == dgvRoomList.Columns["EditRoom"].Index)
                {
                    //uCRoomCRUD.ID= roomid.ToString();
                    uCRoomCRUD.ROOMNumber = roomnumber;
                    this.Controls.Clear();
                    this.Controls.Add(uCRoomCRUD);
                }
            }
        }
        private void BindGrid()
        {
            DataTable dt = roomService.GetPagedRooms(1, pageSize);
            DataTable dt1 = roomService.GetAllRooms();
            int rowCount = dt1.Rows.Count;
            totalPage = rowCount / pageSize;
            if (rowCount % pageSize > 0)
            {
                totalPage += 1;
            }
            lblPageNo.Text = $"Page 1 of {totalPage}";
            dgvRoomList.AutoGenerateColumns = false;
            dgvRoomList.DataSource = dt;
        }

        private void UCRoomList_Load(object sender, EventArgs e)
        {
            BindGrid();
            txtSearch.Text = "Search by Room Type...";

        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by Room Type...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by Room Type...";
                txtSearch.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
