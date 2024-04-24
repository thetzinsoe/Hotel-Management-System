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
                int roomId = Convert.ToInt32(dgvRoomList.Rows[e.RowIndex].Cells["RoomID"].Value);
                if (e.ColumnIndex == dgvRoomList.Columns["RoomID"].Index)
                {
                    uCRoomCRUD.ID = roomId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(uCRoomCRUD);
                }
            }
        }

        private void UCRoomList_Load(object sender, EventArgs e)
        {
            DataTable dt = roomService.GetAllRooms();
            dgvRoomList.DataSource = dt;
        }
    }
}
