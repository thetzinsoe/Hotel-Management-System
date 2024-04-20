using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.Common;
using HotelManagementSystem.Entities.Reservation;

namespace HotelManagementSystem.DAO.Reservation
{
    public class ReservationDao
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
            strSql = "SELECT * FROM Reservation Where is_deleted="+0;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable GetAllRoom()
        {
            strSql = "SELECT * FROM Room Where is_deleted=0 AND is_occupied="+0;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool RoomUpdate(int id, int is_occupied)
        {
            strSql = "UPDATE Room SET is_occupied = @is_occupied WHERE room_id = @room_id";
            SqlParameter[] sqlParam = {
                new SqlParameter("@room_id", id),
                new SqlParameter("@is_occupied", is_occupied)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Get(int id)
        {
            string strSql = "SELECT t1.*, t2.room_no FROM Reservation t1 " +
                "JOIN Room t2 ON t1.room_id = t2.room_id WHERE reservation_id ="+id;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="">.</param>
        public bool Insert(ReservationEntity reservationEntity)
        {
            try
            {
                string strSql = "INSERT INTO Reservation(room_id, room_number, checkin_date, checkout_date, customer_name, customer_phoneNo, created_date, updated_date)" +
                                "VALUES(@room_id, @room_number, @checkin_date, @checkout_date, @customer_name, @customer_phoneNo, @created_date, @updated_date)";

                SqlParameter[] sqlParam = {
            new SqlParameter("@room_id", reservationEntity.room_id),
            new SqlParameter("@room_number", reservationEntity.room_number),
            new SqlParameter("@checkin_date", reservationEntity.checkin_date),
            new SqlParameter("@checkout_date", reservationEntity.checkout_date),
            new SqlParameter("@customer_name", reservationEntity.customer_name),
            new SqlParameter("@customer_phoneNo", reservationEntity.customer_phoneNo),
            new SqlParameter("@created_date", reservationEntity.created_date),
            new SqlParameter("@updated_date", reservationEntity.updated_date)
        };

                bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
                return success;
            }
            catch (Exception ex)
            {
                // Handle exception or log error
                Console.WriteLine("Error occurred while inserting Reservation: " + ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Update(ReservationEntity reservationEntity)
        {
            try
            {
                strSql = "UPDATE Reservation SET room_id = @room_id ,room_number = @room_number ,checkin_date = @checkin_date ,checkout_date = @checkout_date ,customer_name = @customer_name, customer_phoneNo = @customer_phoneNo, updated_date = @updated_date WHERE reservation_id = @reservation_id";

                SqlParameter[] sqlParam =  {
            new SqlParameter("@room_id", reservationEntity.room_id),
            new SqlParameter("@room_number", reservationEntity.room_number),
            new SqlParameter("@checkin_date", reservationEntity.checkin_date),
            new SqlParameter("@checkout_date", reservationEntity.checkout_date),
            new SqlParameter("@customer_name", reservationEntity.customer_name),
            new SqlParameter("@customer_phoneNo", reservationEntity.customer_phoneNo),
            new SqlParameter("@updated_date", reservationEntity.updated_date),
            new SqlParameter("@reservation_id", reservationEntity.reservation_id) // Ensure Reservation is set
        };

                bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

                return success;
            }
            catch (Exception ex)
            {
                // Handle exception or log error
                Console.WriteLine("Error occurred while updating Reservation: " + ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="id">.</param>
        public bool Delete(int id)
        {
            strSql = "UPDATE Reservation SET is_deleted = @is_deleted WHERE reservation_id = @reservation_id";
            SqlParameter[] sqlParam = {
                new SqlParameter("@reservation_id", id),
                new SqlParameter("@is_deleted", 1),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
        #endregion
    }
}
