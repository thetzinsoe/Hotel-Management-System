using System;
using System.Collections.Generic;
using System.Data;
using HotelManagementSystem.Entities.Payment;
using HotelManagementSystem.DAO.Payment;

namespace HotelManagementSystem.Services.Payment
{
    public class PaymentService
    {
        /// <summary>
        /// Define product Dao..
        /// </summary>
        private PaymentDao paymentDao = new PaymentDao();
       
        #region==========Employee========== 
        /// <summary>
        /// Get All.
        /// </summary>
        public DataTable GetAll()
        {
            DataTable dt = paymentDao.GetAll();
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
            DataTable dt = paymentDao.Get(id);
            return dt;
        }
        
        public DataTable GetWithPagination(int offset,int pageSize)
        {
            DataTable dt = paymentDao.GetWithPagination(offset,pageSize);
            return dt;
        }

        /// <summary>
        /// Save Employee.
        /// </summary>
        /// <param name="ReservationEntity">.</param>
        public bool Insert(PaymentEntity paymentEntity)
        {
            return paymentDao.Insert(paymentEntity);
        }

        /// <summary>
        /// Update Employee.
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Update(PaymentEntity paymentEntity)
        {
            return paymentDao.Update(paymentEntity);
        }

        /// <summary>
        /// Delete Employee.
        /// </summary>
        /// <param name="id">.</param>
        public bool Delete(int id)
        {
            return paymentDao.Delete(id);
        }
    }
}
