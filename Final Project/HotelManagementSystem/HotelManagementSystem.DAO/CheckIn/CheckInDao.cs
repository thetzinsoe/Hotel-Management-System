using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.Common;
using HotelManagementSystem.Entities.CheckIn;

namespace HotelManagementSystem.DAO.CheckIn
{
    public class CheckInDao
    {
        /// <summary>
        /// Defines Database Connection..
        /// </summary>
        private DbConnection connection = new DbConnection();

        /// <summary>
        /// Defines strSql..
        /// </summary>
        private string strSql = String.Empty;

        /// <summary>
        /// Defines the resultDataTable.
        /// </summary>
        private DataTable resultDataTable = new DataTable();

        /// <summary>
        /// Defines the existCount.
        /// </summary>
        private int existCount;

        #region==========Product========== 

        /// <summary>
        /// Get All
        /// </summary>
        public DataTable GetAll()
        {
            strSql = "SELECT * FROM Checkin Where is_deleted=" + 0;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }


        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM Checkin " +
                      "WHERE  checkin_id= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="">.</param>
        public bool Insert(CheckInEntity checkInEntity)
        {
            try
            {
                string strSql = "INSERT INTO Checkin(room_id, guest_id, checkin_date, checkout_date)" +
                                "VALUES(@room_id, @guest_id, @checkin_date, @checkout_date)";

                SqlParameter[] sqlParam = {
            new SqlParameter("@room_id", checkInEntity.room_id),
            new SqlParameter("@guest_id", checkInEntity.guest_id),
            new SqlParameter("@checkin_date", checkInEntity.checkin_date),
            new SqlParameter("@checkout_date", checkInEntity.checkout_date)
        };

                bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
                return success;
            }
            catch (Exception ex)
            {
                // Handle exception or log error
                Console.WriteLine("Error occurred while inserting checkin: " + ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Update(CheckInEntity checkInEntity)
        {
            try
            {
                strSql = "UPDATE Checkin SET room_id = @room_id ,guest_id = @guest_id ,checkin_date = @checkin_date ,checkout_date = @checkout_date WHERE checkin_id = @checkin_id";

                SqlParameter[] sqlParam =  {
            new SqlParameter("@room_id", checkInEntity.room_id),
            new SqlParameter("@guest_id", checkInEntity.guest_id),
            new SqlParameter("@checkin_date", checkInEntity.checkin_date),
            new SqlParameter("@checkout_date", checkInEntity.checkout_date),
            new SqlParameter("@checkin_id", checkInEntity.checkin_id) // Ensure ProductId is set
        };

                bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

                return success;
            }
            catch (Exception ex)
            {
                // Handle exception or log error
                Console.WriteLine("Error occurred while updating checkin: " + ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="id">.</param>
        public bool Delete(int id)
        {
            strSql = "UPDATE Checkin SET is_deleted = @isdeleted WHERE checkin_id = @checkin_id";
            SqlParameter[] sqlParam = {
                new SqlParameter("@checkin_id", id),
                new SqlParameter("@is_deleted", 1),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
        #endregion
    }
}
