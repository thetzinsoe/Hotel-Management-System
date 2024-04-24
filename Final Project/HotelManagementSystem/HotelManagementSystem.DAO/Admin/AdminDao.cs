using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.Common;

namespace HotelManagementSystem.DAO.Admin
{
    public class AdminDao
    {
        private DbConnection connection = new DbConnection();
        private string strSql = String.Empty;


        public DataTable GetAllAdmins()
        {
            strSql = "SELECT * FROM Admin";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        // Get Admin by Id
        public DataTable GetAdminById(int adminId)
        {
            strSql = "SELECT * FROM Guest " +
                      "WHERE  guestId= " + adminId + "AND is_deleted = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable GetAdminByUsername(string username)
        {
            strSql = "SELECT * FROM Guest " +
                      "WHERE  guestId= " + username + "AND is_deleted = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        // Insert Admin
        public bool InsertAdmin(AdminEntity adminEntity)
        {
            strSql = "INSERT INTO Admin(username, password, role, created_date, updated_date)" +
                     "VALUES(@Username, @Password, @Role, @CreatedDate, @UpdatedDate)";
            SqlParameter[] sqlParam = {
                new SqlParameter("@Username", adminEntity.Username),
                new SqlParameter("@Password", adminEntity.Password),
                new SqlParameter("@Role", adminEntity.Role),
                new SqlParameter("@CreatedDate", adminEntity.CreatedDate),
                new SqlParameter("@UpdatedDate", adminEntity.UpdatedDate)
            };

            return connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
        }

        // Update Admin
        public bool UpdateAdmin(AdminEntity adminEntity)
        {
            strSql = "UPDATE Admin SET username = @Username, password = @Password, role = @Role, updated_date = @UpdatedDate WHERE adminId = @AdminId";
            SqlParameter[] sqlParam = {
                new SqlParameter("@AdminId", adminEntity.UserId),
                new SqlParameter("@Username", adminEntity.Username),
                new SqlParameter("@Password", adminEntity.Password),
                new SqlParameter("@Role", adminEntity.Role),
                new SqlParameter("@UpdatedDate", adminEntity.UpdatedDate)
            };

            return connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
        }

        // Delete Admin
        public bool DeleteAdmin(int adminId)
        {
            strSql = "DELETE FROM Admin WHERE adminId = @AdminId";
            SqlParameter[] sqlParam = {
                new SqlParameter("@AdminId", adminId)
            };

            return connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
        }
    }
}
