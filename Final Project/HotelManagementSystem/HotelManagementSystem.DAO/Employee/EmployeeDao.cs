using System;
using HotelManagementSystem.DAO.Common;
using HotelManagementSystem.Entities.Employee;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagementSystem.DAO.Employee
{
    /// <summary>
    /// Defines the <see cref="EmployeeDao" />.
    /// </summary>
    public class EmployeeDao
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
            strSql = "SELECT * FROM Employee where is_deleted = 0";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public DataTable Get(int employeeId)
        {
            strSql = "SELECT * FROM Employee " +
                      "WHERE  employee_id= " + employeeId + "AND is_deleted = 0";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="name">.</param>
        /// <returns></returns>
        public DataTable Search(string name)
        {
            strSql = "SELECT * FROM Employee " +
             "WHERE full_name LIKE '%" + name + "%' AND is_deleted = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
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
                strSql = "Select TOP " + pageSize + " * from Employee WHERE is_deleted = 0 ORDER BY employee_id";
            }
            else
            {
                int offset = (page - 1) * pageSize;
                strSql = $"SELECT TOP {pageSize} * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY employee_id) AS RowNum FROM Employee WHERE is_deleted = 0) AS T WHERE RowNum > {offset}";
            }
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Insert(EmployeeEntity employeeEntity)
        {
            strSql = "INSERT INTO Employee(full_name,phone_number,gender,position,nrc_number,dob,image,joined_date,address,created_date,updated_date,created_userId,updated_userId)" +
                     "VALUES(@FullName, @PhoneNumber, @Gender, @Position, @NRCNumber, @Dob, @Image, @JoinedDate, @Address, @CreatedDate, @UpdatedDate, @CreatedUserId, @UpdatedUserId)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@FullName", employeeEntity.fullName),
                                        new SqlParameter("@PhoneNumber", employeeEntity.phoneNumber),
                                        new SqlParameter("@Gender", employeeEntity.gender),
                                        new SqlParameter("@Position", employeeEntity.position),
                                        new SqlParameter("@NRCNumber", employeeEntity.nrcNumber),
                                        new SqlParameter("@Dob", employeeEntity.dob),
                                        new SqlParameter("@Image", employeeEntity.image),
                                        new SqlParameter("@JoinedDate", employeeEntity.joinedDate),
                                        new SqlParameter("@Address", employeeEntity.address),
                                        new SqlParameter("@CreatedDate", employeeEntity.createdDateTime),
                                        new SqlParameter("@UpdatedDate", employeeEntity.updatedDateTime),
                                        new SqlParameter("@CreatedUserId", employeeEntity.createdUserId),
                                        new SqlParameter("@UpdatedUserId", employeeEntity.updatedUserId)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <param name="employeeEntity">.</param>
        public bool Update(EmployeeEntity employeeEntity)
        {
            strSql = "UPDATE Employee SET full_name = @FullName,phone_number = @PhoneNumber,gender = @Gender,position = @Position,nrc_number = @NRCNumber,dob = @Dob,image = @Image,joined_date = @JoinedDate,address = @Address,updated_date = @UpdatedDate,updated_userId = @UpdatedUserId WHERE employee_id = @EmployeeId";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@EmployeeId", employeeEntity.employeeId),
                                        new SqlParameter("@FullName", employeeEntity.fullName),
                                        new SqlParameter("@PhoneNumber", employeeEntity.phoneNumber),
                                        new SqlParameter("@Gender", employeeEntity.gender),
                                        new SqlParameter("@Position", employeeEntity.position),
                                        new SqlParameter("@NRCNumber", employeeEntity.nrcNumber),
                                        new SqlParameter("@Dob", employeeEntity.dob),
                                        new SqlParameter("@Image", employeeEntity.image),
                                        new SqlParameter("@JoinedDate", employeeEntity.joinedDate),
                                        new SqlParameter("@Address", employeeEntity.address),
                                        new SqlParameter("@UpdatedDate", employeeEntity.updatedDateTime),
                                        new SqlParameter("@UpdatedUserId", employeeEntity.updatedUserId)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="employeeId">.</param>
        public bool Delete(int employeeId, int userId)
        {
            strSql = "UPDATE Employee SET is_deleted = @IsDeleted, deleted_userId = @DeletedUserId WHERE employee_id =@EmployeeId";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@EmployeeId", employeeId),
                                        new SqlParameter("@IsDeleted", 1),
                                        new SqlParameter("@DeletedUserId", userId)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
        #endregion
    }
}
