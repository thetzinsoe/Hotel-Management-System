using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.CheckIn;
using HotelManagementSystem.DAO.Payment;
using HotelManagementSystem.Entities.CheckIn;

namespace HotelManagementSystem.Services.CheckIn
{
    public class CheckInService
    {

        /// <summary>
        /// Define product Dao..
        /// </summary>
        private CheckInDao checkInDao = new CheckInDao();


        #region==========Employee========== 
        /// <summary>
        /// Get All.
        /// </summary>
        public DataTable GetAll()
        {
            DataTable dt = checkInDao.GetAll();
            return dt;
        }

        public DataTable GetAllGuest()
        {
            DataTable dt = checkInDao.GetAllGuest();
            return dt;
        }
        
        #endregion

        /// <summary>
        /// Get.
        /// </summary>
        /// <param name="id">.</param>
        /// <returns>.</returns>
        public DataTable Get(int id)
        {
            DataTable dt = checkInDao.Get(id);
            return dt;
        }
        public DataTable haveRoom(int id)
        {
            DataTable dt = checkInDao.haveRoom(id);
            return dt;
        }

        public DataTable GetWithPagination(int offset, int pageSize)
        {
            DataTable dt = checkInDao.GetWithPagination(offset, pageSize);
            return dt;
        }
        
        public DataTable Search(int searchType, string searchValue)
        {
            DataTable dt = checkInDao.Search(searchType, searchValue);
            return dt;
        }

        /// <summary>
        /// Save Employee.
        /// </summary>
        /// <param name="ShopEntity">.</param>
        public bool Insert(CheckInEntity checkInEntity)
        {
            return checkInDao.Insert(checkInEntity);
        }

        /// <summary>
        /// Update Employee.
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Update(CheckInEntity checkInEntity)
        {
            return checkInDao.Update(checkInEntity);
        }

        /// <summary>
        /// Delete Employee.
        /// </summary>
        /// <param name="id">.</param>
        public bool Delete(int id)
        {
            return checkInDao.Delete(id);
        }
    }
}
