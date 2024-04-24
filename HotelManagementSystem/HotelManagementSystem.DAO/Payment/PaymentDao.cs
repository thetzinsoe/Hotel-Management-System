using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.Common;
using HotelManagementSystem.Entities.Payment;

namespace HotelManagementSystem.DAO.Payment
{
    public class PaymentDao
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
            strSql = "SELECT * FROM Payment Where is_deleted=" + 0;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable GetWithPagination(int offset,int pageSize)
        {
            strSql = $"SELECT * FROM Payment Where is_deleted=0 ORDER BY [payment_id] OFFSET {offset} ROWS FETCH NEXT {pageSize} ROWS ONLY;";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }


        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Get(int id)
        {
            strSql = "SELECT t1.*, t2.checkin_date, t2.checkout_date FROM Payment t1" +
                      " JOIN Checkin t2 ON t1.checkin_id = t2.checkin_id WHERE  t1.payment_id= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="">.</param>
        public bool Insert(PaymentEntity paymentEntity)
        {
            try
            {
                string strSql = "INSERT INTO Payment(checkin_id, room_fees, extra_fees, description, discount, total_fees, payment_type, created_date, updated_date)" +
                                "VALUES(@checkin_id, @room_fees, @extra_fees, @description, @discount, @total_fees, @payment_type, @created_date, @updated_date)";

                SqlParameter[] sqlParam = {
            new SqlParameter("@checkin_id", paymentEntity.checkin_id),
            new SqlParameter("@room_fees", paymentEntity.room_fees),
            new SqlParameter("@extra_fees", paymentEntity.extra_fees),
            new SqlParameter("@description", paymentEntity.description),
            new SqlParameter("@discount", paymentEntity.discount),
            new SqlParameter("@total_fees", paymentEntity.total_fees),
            new SqlParameter("@payment_type", paymentEntity.payment_type),
            new SqlParameter("@created_date", paymentEntity.created_date),
            new SqlParameter("@updated_date", paymentEntity.updated_date),
        };

                bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
                return success;
            }
            catch (Exception ex)
            {
                // Handle exception or log error
                Console.WriteLine("Error occurred while inserting Payment: " + ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Update(PaymentEntity paymentEntity)
        {
            try
            {
                strSql = "UPDATE Payment SET checkin_id = @checkin_id ,room_fees = @room_fees ,extra_fees = @extra_fees ,description = @description ,discount = @discount, total_fees = @total_fees, payment_type=@payment_type WHERE payment_id = @payment_id";

                SqlParameter[] sqlParam =  {
            new SqlParameter("@checkin_id", paymentEntity.checkin_id),
            new SqlParameter("@room_fees", paymentEntity.room_fees),
            new SqlParameter("@extra_fees", paymentEntity.extra_fees),
            new SqlParameter("@description", paymentEntity.description),
            new SqlParameter("@discount", paymentEntity.discount),
            new SqlParameter("@total_fees", paymentEntity.total_fees),
            new SqlParameter("@payment_type", paymentEntity.payment_type),
            new SqlParameter("@payment_id", paymentEntity.payment_id),
        };

                bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

                return success;
            }
            catch (Exception ex)
            {
                // Handle exception or log error
                Console.WriteLine("Error occurred while updating Payment: " + ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="id">.</param>
        public bool Delete(int id)
        {
            strSql = "UPDATE Payment SET is_deleted = @is_deleted WHERE payment_id = @payment_id";
            SqlParameter[] sqlParam = {
                new SqlParameter("@payment_id", id),
                new SqlParameter("@isDeleted", 1),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
        #endregion
    }
}
