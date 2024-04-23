using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.Common;
using HotelManagementSystem.Entities.CheckIn;
using HotelManagementSystem.Entities.Reservation;

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
            strSql =  "SELECT t1.checkin_id, t1.checkin_date, t1.checkout_date, t2.room_no , t3.full_name ,t3.nrc_number "+
             "FROM Checkin t1 JOIN Room t2 ON t1.room_id = t2.room_id "+
            "JOIN Guest t3 ON t1.guest_id = t3.guest_id Where t1.is_deleted="+0;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable GetAllGuest()
        {
             strSql = "SELECT * FROM Guest Where is_deleted=" + 0;
             return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Get(int id)
        {
            strSql = "SELECT t1.room_id, t1.checkin_id, t1.checkin_date, t1.checkout_date ,t2.room_id ,t2.room_no ,t2.room_price, t3.full_name ,t3.nrc_number " +
            "FROM Checkin t1 JOIN Room t2 ON t1.room_id = t2.room_id " +
           "JOIN Guest t3 ON t1.guest_id = t3.guest_id Where t1.checkin_id=" + id;
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
                string strSql = "INSERT INTO Checkin(room_id, guest_id, checkin_date, checkout_date, created_date, updated_date)" +
                                "VALUES(@room_id, @guest_id, @checkin_date, @checkout_date, @created_date, @updated_date)";

                SqlParameter[] sqlParam = {
            new SqlParameter("@room_id", checkInEntity.room_id),
            new SqlParameter("@guest_id", checkInEntity.guest_id),
            new SqlParameter("@checkin_date", checkInEntity.checkin_date),
            new SqlParameter("@checkout_date", checkInEntity.checkout_date),
            new SqlParameter("@created_date", checkInEntity.created_date),
            new SqlParameter("@updated_date", checkInEntity.updated_date)
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
                strSql = "UPDATE Checkin SET room_id = @room_id ,guest_id = @guest_id ,checkin_date = @checkin_date ,checkout_date = @checkout_date ,@updated_date=updated_date WHERE checkin_id = @checkin_id";

                SqlParameter[] sqlParam =  {
            new SqlParameter("@room_id", checkInEntity.room_id),
            new SqlParameter("@guest_id", checkInEntity.guest_id),
            new SqlParameter("@checkin_date", checkInEntity.checkin_date),
            new SqlParameter("@checkout_date", checkInEntity.checkout_date),
            new SqlParameter("@updated_date", checkInEntity.updated_date),
            new SqlParameter("@checkin_id", checkInEntity.checkin_id)
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
            strSql = "UPDATE Checkin SET is_deleted = @is_deleted WHERE checkin_id = @checkin_id";
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
