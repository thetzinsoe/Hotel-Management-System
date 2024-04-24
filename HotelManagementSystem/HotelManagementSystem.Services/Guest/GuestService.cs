using System;
using HotelManagementSystem.Entities.Guest;
using HotelManagementSystem.DAO.Guest;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagementSystem.Services.Guest
{
    /// <summary>
    /// Defines the <see cref="GuestService" />.
    /// </summary>
    public class GuestService
    {
        /// <summary>
        /// Define guestDao..
        /// </summary>
        private GuestDao guestDao = new GuestDao();


        #region==========Guest========== 
        /// <summary>
        /// Get All.
        /// </summary>
        public DataTable GetAll()
        {
            DataTable dt = guestDao.GetAll();
            return dt;
        }
        

        /// <summary>
        /// Get.
        /// </summary>
        /// <param name="guestId">.</param>
        /// <returns>.</returns>
        public DataTable Get(int guestId)
        {
            DataTable dt = guestDao.Get(guestId);
            return dt;
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="name">.</param>
        /// <returns>.</returns>
        public DataTable Search(int searchType, string name)
        {
            DataTable dt = guestDao.Search(searchType, name);
            return dt;
        }

        /// <summary>
        /// GetRecord
        /// </summary>
        /// <param name="page">.</param>
        /// <param name="pageSize"></param>
        /// <returns>.</returns>
        public DataTable GetRecord(int page, int pageSize)
        {
            DataTable dt = guestDao.GetRecord(page, pageSize);
            return dt;
        }
        /// <summary>
        /// Save Guest.
        /// </summary>
        /// <param name="guestEntity">.</param>
        public bool Insert(GuestEntity guestEntity)
        {
            return guestDao.Insert(guestEntity);
        }

        /// <summary>
        /// Update Guest.
        /// </summary>
        /// <param name="guestEntity">.</param>
        public bool Update(GuestEntity guestEntity)
        {
            return guestDao.Update(guestEntity);
        }

        /// <summary>
        /// Delete Guest.
        /// </summary>
        /// <param name="guestId">.</param>
        /// <param name="userId">.</param>
        public bool Delete(int guestId)
        {
            return guestDao.Delete(guestId);
        }
        #endregion
    }
}
