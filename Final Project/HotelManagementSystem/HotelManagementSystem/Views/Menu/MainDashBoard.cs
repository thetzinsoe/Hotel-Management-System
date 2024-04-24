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
using HotelManagementSystem.Views.CheckIn;
using HotelManagementSystem.Views.Employee;
using HotelManagementSystem.Views.Guest;
using HotelManagementSystem.Views.Reservation;
using HotelManagementSystem.Views.Room;

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

        private void btnViewRoom_Click(object sender, EventArgs e)
        {
           UCRoomList uCRoomList = new UCRoomList();
            this.Controls.Clear();
            this.Controls.Add(uCRoomList);
        }

        private void btnViewReservation_Click(object sender, EventArgs e)
        {
            UCReservationList uCReservationList = new UCReservationList();
            this.Controls.Clear();
            this.Controls.Add(uCReservationList);
        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            UCEmployeeList uCEmployeeList = new UCEmployeeList();
            this.Controls.Clear();
            this.Controls.Add(uCEmployeeList);
        }

        private void btnViewRoom1_Click(object sender, EventArgs e)
        {
            UCRoomList uCRoomList = new UCRoomList();
            this.Controls.Clear();
            this.Controls.Add(uCRoomList);
        }

        private void btnViewCheck_Click(object sender, EventArgs e)
        {
            UCCheckInList uCCheckInList = new UCCheckInList();
            this.Controls.Clear();
            this.Controls.Add(uCCheckInList);
        }

        private void btnViewGuest_Click(object sender, EventArgs e)
        {
            UCGuestList uCGuestList = new UCGuestList();
            this.Controls.Clear();
            this.Controls.Add(uCGuestList);
        }
    }
}
