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
using HotelManagementSystem.Services.Employee;
using HotelManagementSystem.Services.Guest;
using HotelManagementSystem.Services.Reservation;
using HotelManagementSystem.Services.Room;

namespace HotelManagementSystem.Views.Menu
{
    public partial class MainDashBoard : UserControl
    {
        GuestService guestService = new GuestService();
        EmployeeService employeeService = new EmployeeService();
        RoomService roomService = new RoomService();
        ReservationService reservationService = new ReservationService();
        CheckInService checkInService = new CheckInService();
        public MainDashBoard()
        {
            InitializeComponent();
        }

        private void MainDashBoard_Load(object sender, EventArgs e)
        {
            DataTable guestData = guestService.GetAll();
            DataTable employeeData = employeeService.GetAll();
            DataTable roomData = roomService.GetAllRooms();
            DataTable resrvationData = reservationService.GetAll();
            DataTable checkinData = checkInService.GetAll();
            TtlRoom.Text = roomData.Rows.Count.ToString();
            TtlGuest.Text = guestData.Rows.Count.ToString();
            TtlEmp.Text = employeeData.Rows.Count.ToString();
            TtlChecked.Text = checkinData.Rows.Count.ToString();
            TtlReservation.Text = resrvationData.Rows.Count.ToString();
            TtlAvailableRoom.Text = (resrvationData.Rows.Count - roomData.Rows.Count).ToString();
        }
    }
}
