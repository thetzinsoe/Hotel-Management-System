using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.CheckIn;
using HotelManagementSystem.DAO.Payment;
using HotelManagementSystem.DAO.Reservation;
using HotelManagementSystem.Entities.Reservation;

namespace HotelManagementSystem.Services.Reservation
{
    public class ReservationService
    {
        /// <summary>
        /// Define product Dao..
        /// </summary>
        private ReservationDao reservationDao = new ReservationDao();

        #region==========Employee========== 
        /// <summary>
        /// Get All.
        /// </summary>
        public DataTable GetAll()
        {
            DataTable dt = reservationDao.GetAll();
            return dt;
        }

        public DataTable GetWithPagination(int offset, int pageSize, string searchValue="")
        {
            DataTable dt = reservationDao.GetWithPagination(offset, pageSize,searchValue);
            return dt;
        }
        public DataTable GetAllRoom()
        {
            DataTable dt = reservationDao.GetAllRoom();
            return dt;
        }
        
        public DataTable GetRoomWithDate(DateTime checkinDate,DateTime checkoutDate)
        {
            DataTable dt = reservationDao.GetRoomWithDate(checkinDate,checkoutDate);
            return dt;
        }

        public bool RoomUpdate(int id, int is_occupied)
        {
            return reservationDao.RoomUpdate(id, is_occupied);
        }
        #endregion

        /// <summary>
        /// Get.
        /// </summary>
        /// <param name="id">.</param>
        /// <returns>.</returns>
        public DataTable Get(int id)
        {
            DataTable dt = reservationDao.Get(id);
            return dt;
        }

        public int FindReservationId(int room_id,DateTime checkin_date,DateTime checkout_date)
        {
            return reservationDao.FindReservationId(room_id,checkin_date,checkout_date); 
        }
        
        public DataTable haveRoom(int id)
        {
            DataTable dt = reservationDao.haveRoom(id);
            return dt;
        }

        /// <summary>
        /// Save Employee.
        /// </summary>
        /// <param name="ReservationEntity">.</param>
        public bool Insert(ReservationEntity reservationEntity)
        {
            return reservationDao.Insert(reservationEntity);
        }

        /// <summary>
        /// Update Employee.
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Update(ReservationEntity reservationEntity)
        {
            return reservationDao.Update(reservationEntity);
        }

        /// <summary>
        /// Delete Employee.
        /// </summary>
        /// <param name="id">.</param>
        public bool Delete(int id)
        {
            return reservationDao.Delete(id);
        }
    }
}
