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
                      "WHERE  guest_id= " + guestId + "AND is_deleted = 0";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="searchtype"></param>
        /// <param name="name">.</param>
        /// <returns></returns>
        public DataTable Search(int searchType, string name)
        {
            if (searchType == 0)
            {
                strSql = "SELECT * FROM Guest " +
             "WHERE full_name LIKE '%" + name + "%' AND is_deleted = 0";
            }
            else if (searchType == 1)
            {
                strSql = "SELECT * FROM Guest " +
             "WHERE nrc_number LIKE '%" + name + "%' AND is_deleted = 0";
            }
            return connection.ExecuteDataTable (CommandType.Text, strSql);
        }

        /// <summary>
        /// GetRecord
        /// </summary>
        /// <param name="page">.</param>
        /// <param name="pageSize">.</param>
        /// <returns></returns>
        public DataTable GetRecord(int page, int pageSize)
        {
            if (page == 1)
            {
                strSql = "Select TOP " + pageSize + " * from Guest WHERE is_deleted = 0 ORDER BY guest_id";
            }
            else
            {
                int offset = (page - 1) * pageSize;
                strSql = $"SELECT TOP {pageSize} * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY guest_id) AS RowNum FROM Guest WHERE is_deleted = 0) AS T WHERE RowNum > {offset}";
            }
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool IsGuestValid(string name, string nrc)
        {
            strSql = "Select Count(*) from Guest where full_name = @FullName and nrc_number = @NRCNumber and is_deleted = 0";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@FullName", name),
                                        new SqlParameter("@NRCNumber", nrc)
                                      };    
            object result = connection.ExecuteScalar(CommandType.Text,strSql, sqlParam);
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        public bool IsGuestValidForUpdating(int id, string name, string nrc)
        {
            strSql = "Select Count(*) from Guest where full_name = @FullName and nrc_number = @NRCNumber and guest_id != @GuestId and is_deleted = 0";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@GuestId", id),
                                        new SqlParameter("@FullName", name),
                                        new SqlParameter("@NRCNumber", nrc)
                                      };
            object result = connection.ExecuteScalar(CommandType.Text, strSql, sqlParam);
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        public bool IsNRCValid(string name, string nrc)
        {
            strSql = "SELECT COUNT(*) FROM Guest WHERE nrc_number = @NRCNumber AND full_name != @FullName AND is_deleted = 0";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@FullName", name),
                                        new SqlParameter("@NRCNumber", nrc)
                                      };
            object result = connection.ExecuteScalar(CommandType.Text, strSql, sqlParam);
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        public bool IsNRCValidForUpdating(int id, string name, string nrc)
        {
            strSql = "SELECT COUNT(*) FROM Guest WHERE nrc_number = @NRCNumber AND full_name != @FullName AND guest_id != @GuestId AND is_deleted = 0";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@GuestId", id),
                                        new SqlParameter("@FullName", name),
                                        new SqlParameter("@NRCNumber", nrc)
                                      };
            object result = connection.ExecuteScalar(CommandType.Text, strSql, sqlParam);
            int count = Convert.ToInt32(result);
            return count > 0;
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
        public bool Delete(int guestId)
        {
            strSql = "UPDATE Guest SET is_deleted = @IsDeleted WHERE guest_id =@GuestId";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@GuestId", guestId),
                                        new SqlParameter("@IsDeleted", 1),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
        #endregion
    }
}
