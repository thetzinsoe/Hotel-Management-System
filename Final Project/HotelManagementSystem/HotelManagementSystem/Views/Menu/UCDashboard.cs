using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Services.Employee;
using HotelManagementSystem.Services.Guest;
using HotelManagementSystem.Services.Room;
using HotelManagementSystem.Views.Employee;

namespace HotelManagementSystem.Views.Menu
{
    public partial class UCDashboard : UserControl
    {
        GuestService guestService = new GuestService();
        EmployeeService employeeService = new EmployeeService();
        RoomService roomService= new RoomService();

        public UCDashboard()
        {
            InitializeComponent();
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            DataTable guestData=guestService.GetAll();
            DataTable employeeData=employeeService.GetAll();
            DataTable roomData=roomService.GetAllRooms();
            lblTtlGuest.Text = guestData.Rows.Count.ToString();
            
        }

        private void pnRooms_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
