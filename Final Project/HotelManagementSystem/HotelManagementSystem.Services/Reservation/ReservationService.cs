using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.CheckIn;
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
        
        public DataTable GetAllRoom()
        {
            DataTable dt = reservationDao.GetAllRoom();
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
