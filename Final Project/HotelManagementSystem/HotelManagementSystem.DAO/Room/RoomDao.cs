using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.Entities.Room;
using HotelManagementSystem.DAO.Common;

namespace HotelManagementSystem.DAO.Room
{
    public class RoomDao
    {
        private DbConnection connection = new DbConnection();
        private string strSql = String.Empty;
        private DataTable resultDataTable = new DataTable();
        private int existCount;

        #region==========Room========== 

        public DataTable GetAll()
        {
            strSql = "SELECT * FROM Room WHERE is_deleted = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable Get(int roomId)
        {
            strSql = "SELECT * FROM Room WHERE room_id =" + roomId + " AND is_deleted = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert(RoomEntity roomEntity)
        {
            strSql = "INSERT INTO Room(room_no, room_type, room_price, is_occupied, created_date, updated_date, is_deleted)" +
                " VALUES(@RoomNumber, @RoomType, @Price, @IsOccupied, @CreatedDate, @UpdatedDate, @IsDeleted);";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@RoomNumber", roomEntity.room_number),
                                        new SqlParameter("@RoomType", roomEntity.room_type),
                                        new SqlParameter("@Price", roomEntity.room_price),
                                        new SqlParameter("@IsOccupied", roomEntity.is_occupied),
                                        new SqlParameter("@CreatedDate", roomEntity.created_date),
                                        new SqlParameter("@UpdatedDate", roomEntity.updated_date),
                                        new SqlParameter("@IsDeleted", roomEntity.is_deleted)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        public bool Update(RoomEntity roomEntity)
        {
            strSql = "UPDATE Room SET room_no = @RoomNumber, room_type = @RoomType, room_price = @Price, " +
                     "is_occupied = @IsOccupied, updated_date = @UpdatedDate WHERE room_id = @RoomId";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@RoomId", roomEntity.room_id),
                                        new SqlParameter("@RoomNumber", roomEntity.room_number),
                                        new SqlParameter("@RoomType", roomEntity.room_type),
                                        new SqlParameter("@Price", roomEntity.room_price),
                                        new SqlParameter("@IsOccupied", roomEntity.is_occupied),
                                        new SqlParameter("@UpdatedDate", roomEntity.updated_date)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        public bool Delete(int roomId)
        {
            strSql = "UPDATE Room SET is_deleted = 1 WHERE room_id = @RoomId";
            SqlParameter[] sqlParam = { new SqlParameter("@RoomId", roomId) };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
        public DataTable SearchByType(string roomType)
        {
            strSql = "SELECT * FROM Room WHERE room_type LIKE '%" + roomType + "%' AND is_deleted = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable SearchByRoomNumber(string roomNumber)
        {
            strSql = "SELECT * FROM Room WHERE room_type ='"+roomNumber+"' AND is_deleted = 0";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable GetRecord(int page, int pageSize)
        {
            int offset = (page - 1) * pageSize;
            strSql = $"SELECT * FROM Room WHERE is_deleted = 0 ORDER BY room_id OFFSET {offset} ROWS FETCH NEXT {pageSize} ROWS ONLY";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        #endregion
    }
}
