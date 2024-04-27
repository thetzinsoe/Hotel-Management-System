using System;
using HotelManagementSystem.DAO.Employee;
using HotelManagementSystem.Entities.Employee;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HotelManagementSystem.Services.Employee
{
    /// <summary>
    /// Defines the <see cref="EmployeeService" />.
    /// </summary>
    public class EmployeeService
    {
        /// <summary>
        /// Define employeeDao..
        /// </summary>
        private EmployeeDao employeeDao = new EmployeeDao();


        #region==========Employee========== 
        /// <summary>
        /// Get All.
        /// </summary>
        public DataTable GetAll()
        {
            DataTable dt = employeeDao.GetAll();
            return dt;
        }
        #endregion

        /// <summary>
        /// Get.
        /// </summary>
        /// <param name="employeeId">.</param>
        /// <returns>.</returns>
        public DataTable Get(int employeeId)
        {
            DataTable dt = employeeDao.Get(employeeId);
            return dt;
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="name">.</param>
        /// <returns>.</returns>
        public DataTable Search(int searchType, string name)
        {
            DataTable dt = employeeDao.Search(searchType, name);
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
            DataTable dt = employeeDao.GetRecord(page, pageSize);
            return dt;
        }

        /// <summary>
        /// Save Employee.
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Insert(EmployeeEntity employeeEntity)
        {
            return employeeDao.Insert(employeeEntity);
        }

        /// <summary>
        /// Update Employee.
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Update(EmployeeEntity employeeEntity)
        {
            return employeeDao.Update(employeeEntity);
        }

        /// <summary>
        /// Delete Employee.
        /// </summary>
        /// <param name="employeeId">.</param>
        /// <param name="userId">.</param>
        public bool Delete(int employeeId)
        {
            return employeeDao.Delete(employeeId);
        }

        public bool IsGuestValid(string name, string nrc)
        {
            return employeeDao.IsEmployeeValid(name, nrc);
        }

        public bool IsNRCValid(string name, string nrc)
        {
            return employeeDao.IsNRCValid(name, nrc);
        }

        public bool IsGuestValidForUpdating(int id, string name, string nrc)
        {
            return employeeDao.IsEmployeeValidForUpdating(id, name, nrc);
        }

        public bool IsNRCValidForUpdating(int id, string name, string nrc)
        {
            return employeeDao.IsNRCValidForUpdating(id, name, nrc);
        }
    }
}
