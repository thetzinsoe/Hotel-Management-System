using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.Room
{
    public class RoomEntity
    {
        /// <summary>
        /// Gets or sets the room ID.
        /// </summary>
        public int room_id { get; set; }

        /// <summary>
        /// Gets or sets the room number.
        /// </summary>
        public string room_number { get; set; }

        /// <summary>
        /// Gets or sets the room type.
        /// </summary>
        public string room_type { get; set; }

        /// <summary>
        /// Gets or sets the price of the room.
        /// </summary>
        public decimal room_price { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the room is occupied.
        /// </summary>
        public short is_occupied { get; set; }

        /// <summary>
        /// Gets or sets the created date of the room.
        /// </summary>
        public DateTime created_date { get; set; }
        
        /// <summary>
        /// Gets or sets the created date of the room.
        /// </summary>
        public int created_userId { get; set; }

        /// <summary>
        /// Gets or sets the created date of the room.
        /// </summary>
        public int updated_userId { get; set; }

        /// <summary>
        /// Gets or sets the updated date of the room.
        /// </summary>
        public DateTime updated_date { get; set; }
        ///<summary>
        ///gets or sets Gets or sets the is deleted.
        ///</summary>
        public short is_deleted { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomEntity"/> class.
        /// </summary>
        public RoomEntity()
        {
            InitializeObjectValues();
        }

        /// <summary>
        /// Initializes default values for the object properties.
        /// </summary>
        internal void InitializeObjectValues()
        {
            this.room_id = 0;
            this.room_number = string.Empty;
            this.room_type = string.Empty;
            this.room_price = 0;
            this.is_occupied = 0;
            this.created_userId = 3;
            this.updated_userId = 4;
            this.created_date = DateTime.Now;
            this.updated_date = DateTime.Now;
        }
    }
}
