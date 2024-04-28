using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.Admin;
using HotelManagementSystem.Entities.Admin;

namespace HotelManagementSystem.Services.Admin
{
    public class AdminService
    {
        private AdminDao adminDao = new AdminDao();

        // Get All Admins
        public DataTable GetAllAdmins()
        {
            return adminDao.GetAllAdmins();
        }

        // Get Admin by Id
        public DataTable GetAdminById(int adminId)
        {
            return adminDao.GetAdminById(adminId);
        }
        //get admin by username
        public DataTable GetAdminByUsername(string username)
        {
            return adminDao.GetAdminByUsername(username);
        }
        public DataTable searchByUsername(string username)
        {
            return adminDao.SearchByUsername(username);
        }
        // Insert Admin
        public bool InsertAdmin(AdminEntity adminEntity)
        {
            return adminDao.InsertAdmin(adminEntity);
        }

        // Update Admin
        public bool UpdateAdmin(AdminEntity adminEntity)
        {
            return adminDao.UpdateAdmin(adminEntity);
        }

        // Delete Admin
        public bool DeleteAdmin(int adminId)
        {
            return adminDao.DeleteAdmin(adminId);
        }
    }
}
