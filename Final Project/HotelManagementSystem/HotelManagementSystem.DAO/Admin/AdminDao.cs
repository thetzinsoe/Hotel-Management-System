using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.Common;
using HotelManagementSystem.Entities.Admin;

namespace HotelManagementSystem.DAO.Admin
{
    public class AdminDao
    {
        private DbConnection connection = new DbConnection();
        private string strSql = String.Empty;


        public DataTable GetAllAdmins()
        {
            strSql = "SELECT * FROM [User]";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        // Get Admin by Id
        public DataTable GetAdminById(int user_id)
        {
            strSql = "SELECT * FROM [User] " +
                      "WHERE  user_id= " + user_id + "AND is_deleted = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable GetAdminByUsername(string username)
        {
            strSql = "SELECT * FROM [User] " +
                      "WHERE  username = " + username + "AND is_deleted = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        // Insert Admin
        public bool InsertAdmin(AdminEntity adminEntity)
        {
            strSql = "INSERT INTO [User](username, password, role, created_date, updated_date)" +
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
            strSql = "UPDATE [User] SET username = @Username, password = @Password, role = @Role, updated_date = @UpdatedDate WHERE user_id = @AdminId";
            SqlParameter[] sqlParam = {
                new SqlParameter("@AdminId", adminEntity.user_id),
                new SqlParameter("@Username", adminEntity.Username),
                new SqlParameter("@Password", adminEntity.Password),
                new SqlParameter("@Role", adminEntity.Role),
                new SqlParameter("@UpdatedDate", adminEntity.UpdatedDate)
            };

            return connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
        }

        // Delete Admin
        public bool DeleteAdmin(int user_id)
        {
            strSql = "DELETE FROM [User] WHERE user_id = @AdminId";
            SqlParameter[] sqlParam = {
                new SqlParameter("@AdminId", user_id)
            };

            return connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
        }
    }
}
