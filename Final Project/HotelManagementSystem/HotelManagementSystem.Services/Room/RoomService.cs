using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DAO.Room;
using HotelManagementSystem.Entities.Room;

namespace HotelManagementSystem.Services.Room
{
    public class RoomService
    {
        /// <summary>
        /// Define room Dao.
        /// </summary>
        private RoomDao roomDao = new RoomDao();

        /// <summary>
        /// Get all rooms.
        /// </summary>
        public DataTable GetAllRooms()
        {
            return roomDao.GetAll();
        }

        /// <summary>
        /// Insert new room.
        /// </summary>
        /// <param name="roomEntity">Room information.</param>
        public bool InsertRoom(RoomEntity roomEntity)
        {
            return roomDao.Insert(roomEntity);
        }

        /// <summary>
        /// Update room information.
        /// </summary>
        /// <param name="roomEntity">Room information.</param>
        public bool UpdateRoom(RoomEntity roomEntity)
        {
            return roomDao.Update(roomEntity);
        }

        /// <summary>
        /// Delete room by ID.
        /// </summary>
        /// <param name="roomId">Room ID.</param>
        public bool DeleteRoom(int roomId)
        {
            return roomDao.Delete(roomId);
        }

        /// <summary>
        /// Search rooms by room type.
        /// </summary>
        /// <param name="roomType">Room type to search.</param>
        /// <returns>Matching room information.</returns>
        public DataTable SearchRoomsByType(string roomType)
        {
            return roomDao.SearchByType(roomType);
        }

        /// <summary>
        /// Get paged room records.
        /// </summary>
        /// <param name="page">Page number.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns>Room records for the specified page.</returns>
        public DataTable GetPagedRooms(int page, int pageSize)
        {
            return roomDao.GetRecord(page, pageSize);
        }
    }
}
