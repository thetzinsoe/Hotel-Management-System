using HotelManagementSystem.Entities.Guest;
using HotelManagementSystem.DAO.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.DAO.Guest
{
    /// <summary>
    /// Defines the <see cref="GuestDao" />.
    /// </summary>
    public class GuestDao
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
            strSql = "SELECT * FROM Guest where is_deleted = 0";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="guestId"></param>
        /// <returns></returns>
        public DataTable Get(int guestId)
        {
            strSql = "SELECT * FROM Guest " +
                      "WHERE  guestId= " + guestId + "AND is_deleted = 0";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Create Guest
        /// </summary>
        /// <param name="guestEntity">.</param>
        public bool Insert(GuestEntity guestEntity)
        {
            strSql = "INSERT INTO Guest(full_name,phone_number,gender,nationality,nrc_number,dob,address,created_date,updated_date)" +
                     "VALUES(@FullName, @PhoneNumber, @Gender, @Nationality, @NRCNumber, @Dob, @Address, @CreatedDate, @UpdatedDate)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@FullName", guestEntity.fullName),
                                        new SqlParameter("@PhoneNumber", guestEntity.phoneNumber),
                                        new SqlParameter("@Gender", guestEntity.gender),
                                        new SqlParameter("@Nationality", guestEntity.nationality),
                                        new SqlParameter("@NRCNumber", guestEntity.nrcNumber),
                                        new SqlParameter("@Dob", guestEntity.dob),
                                        new SqlParameter("@Address", guestEntity.address),
                                        new SqlParameter("@CreatedDate", guestEntity.createdDate),
                                        new SqlParameter("@UpdatedDate", guestEntity.updatedDate),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        /// <summary>
        /// Update Guest
        /// </summary>
        /// <param name="guestEntity">.</param>
        public bool Update(GuestEntity guestEntity)
        {
            strSql = "UPDATE Guest SET full_name = @FullName,phone_number = @PhoneNumber,gender = @Gender,nationality = @Nationality,nrc_number = @NRCNumber,dob = @Dob,address = @Address,updated_date = @UpdatedDate WHERE guest_id = @GuestId";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@GuestId", guestEntity.guestId),
                                        new SqlParameter("@FullName", guestEntity.fullName),
                                        new SqlParameter("@PhoneNumber", guestEntity.phoneNumber),
                                        new SqlParameter("@Gender", guestEntity.gender),
                                        new SqlParameter("@Nationality", guestEntity.nationality),
                                        new SqlParameter("@NRCNumber", guestEntity.nrcNumber),
                                        new SqlParameter("@Dob", guestEntity.dob),
                                        new SqlParameter("@Address", guestEntity.address),
                                        new SqlParameter("@UpdatedDate", guestEntity.updatedDate),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="guestId">.</param>
        public bool Delete(int guestId, int userId)
        {
            strSql = "UPDATE Guest SET is_deleted = @IsDeleted, deleted_userId = @DeletedUserId WHERE guest_id =@GuestId";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@GuestId", guestId),
                                        new SqlParameter("@IsDeleted", 1),
                                        new SqlParameter("@DeletedUserId", userId)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
        #endregion
    }
}
