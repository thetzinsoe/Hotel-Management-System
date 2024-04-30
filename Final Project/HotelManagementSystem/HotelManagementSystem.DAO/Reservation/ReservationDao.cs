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

        public int FindReservationId(int room_id, DateTime checkin_date, DateTime checkout_date)
        {
            int id = 0;
            string strSql = "SELECT reservation_id FROM Reservation WHERE room_id='" + room_id + "'" +
                            " AND checkin_date = '" + checkin_date.ToString("yyyy-MM-dd") + "' AND checkout_date = '" + checkout_date.ToString("yyyy-MM-dd") + "'";

            DataTable dt = connection.ExecuteDataTable(CommandType.Text, strSql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    id = Convert.ToInt32(dataRow["reservation_id"]);
                }
            }

            return id;
        }

        public DataTable GetAllRoom()
        {
            strSql = "SELECT * FROM Room Where is_deleted = 0 AND is_occupied = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable GetWithPagination(int offset, int pageSize, string searchValue = "")
        {
            string strSql = $"SELECT * FROM Reservation WHERE customer_name LIKE '%{searchValue}%' AND is_deleted = 0 " +
                 $"ORDER BY [reservation_id] OFFSET {offset} ROWS FETCH NEXT {pageSize} ROWS ONLY;";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        //public DataTable GetRoomWithDate(DateTime checkinDate)
        //{
        //    string strSql = "SELECT t1.*, t2.checkout_date " +
        //                    "FROM Room t1 " +
        //                    "LEFT JOIN Checkin t2 ON t1.room_id = t2.room_id " +
        //                    "WHERE (t1.is_deleted = 0 AND t1.is_occupied = 0) " +
        //                    "OR (t1.is_occupied = 1 AND t2.checkout_date < '" + checkinDate + "' AND t2.is_deleted = 0)";

        //    return connection.ExecuteDataTable(CommandType.Text, strSql);
        //}


        //public DataTable GetRoomWithDate(DateTime checkinDate,DateTime checkoutDate)
        //{
        //    string strSql = "SELECT DISTINCT t1.*, t2.checkout_date " +
        //                    "FROM Room t1 " +
        //                    "LEFT JOIN Checkin t2 ON t1.room_id = t2.room_id " +
        //                    "LEFT JOIN Reservation t3 ON t3.room_id = t1.room_id " +
        //                    "WHERE (t1.is_deleted = 0 AND t1.is_occupied = 0) " +
        //                    "OR (t3.checkout_date < '" + checkinDate + "' AND t3.is_deleted = 0 AND t2.room_id IS NULL) " +
        //                    "OR (t2.checkout_date < '" + checkinDate + "' AND t2.is_deleted = 0 AND t1.is_occupied = 1) " +
        //                    "OR (t3.room_id IS NULL AND t2.room_id IS NULL)";

        //    return connection.ExecuteDataTable(CommandType.Text, strSql);
        //}

        public DataTable GetRoomWithDate(DateTime checkinDate,DateTime checkoutDate)
        {
            strSql = "SELECT room_id, room_no FROM Room WHERE room_id NOT IN (" +
                "SELECT DISTINCT reservation.room_id " +
                "FROM Reservation WHERE '"+checkoutDate+"' >= reservation.checkin_date " +
                "AND '"+checkinDate+ "' <= reservation.checkout_date AND (reservation.is_deleted = 0 OR reservation.is_deleted = 2)) AND Room.is_deleted = 0";

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
            string strSql = "SELECT t1.*, t2.room_no, t2.room_id FROM Reservation t1 " +
                "JOIN Room t2 ON t1.room_id = t2.room_id WHERE reservation_id ="+id;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable haveRoom(int id)
        {
            string strSql = "SELECT * FROM Reservation " +
                "WHERE room_id ='"+id+"' AND is_deleted=0";
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
                string strSql = "INSERT INTO Reservation(room_id, room_number, checkin_date, checkout_date, customer_name, customer_phoneNo, created_date, updated_date, is_deleted)" +
                                "VALUES(@room_id, @room_number, @checkin_date, @checkout_date, @customer_name, @customer_phoneNo, @created_date, @updated_date, @is_deleted)";

                SqlParameter[] sqlParam = {
            new SqlParameter("@room_id", reservationEntity.room_id),
            new SqlParameter("@room_number", reservationEntity.room_number),
            new SqlParameter("@checkin_date", reservationEntity.checkin_date),
            new SqlParameter("@checkout_date", reservationEntity.checkout_date),
            new SqlParameter("@customer_name", reservationEntity.customer_name),
            new SqlParameter("@customer_phoneNo", reservationEntity.customer_phoneNo),
            new SqlParameter("@created_date", reservationEntity.created_date),
            new SqlParameter("@updated_date", reservationEntity.updated_date),
            new SqlParameter("@is_deleted", reservationEntity.is_deleted)
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
                strSql = "UPDATE Reservation SET room_id = @room_id ,room_number = @room_number ,checkin_date = @checkin_date ,checkout_date = @checkout_date ,customer_name = @customer_name, customer_phoneNo = @customer_phoneNo, updated_date = @updated_date, is_deleted = @is_deleted WHERE reservation_id = @reservation_id";

                SqlParameter[] sqlParam =  {
            new SqlParameter("@room_id", reservationEntity.room_id),
            new SqlParameter("@room_number", reservationEntity.room_number),
            new SqlParameter("@checkin_date", reservationEntity.checkin_date),
            new SqlParameter("@checkout_date", reservationEntity.checkout_date),
            new SqlParameter("@customer_name", reservationEntity.customer_name),
            new SqlParameter("@customer_phoneNo", reservationEntity.customer_phoneNo),
            new SqlParameter("@updated_date", reservationEntity.updated_date),
            new SqlParameter("@is_deleted", reservationEntity.is_deleted),
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
