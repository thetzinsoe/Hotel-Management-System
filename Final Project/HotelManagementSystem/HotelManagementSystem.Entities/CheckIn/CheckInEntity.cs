using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.CheckIn
{
    public class CheckInEntity
    {
        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public int checkin_id { get; set; }

        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public int room_id { get; set; }

        /// <summary>
        /// Gets or Sets name
        /// </summary>
        public int guest_id { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public DateTime checkin_date { get; set; }

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        public DateTime checkout_date { get; set; }

        /// <summary>
        /// Gets or sets the joining date
        /// </summary>
        public DateTime created_date { get; set; }

        /// <summary>
        /// Gets or sets the joining date
        /// </summary>
        public DateTime updated_date { get; set; }

        /// <summary>
        /// Gets or sets the joining date
        /// </summary>
        public int is_deleted { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="ShopEntity"/> class.
        /// </summary>
        public CheckInEntity()
        {
            InitializedObjectValue();
        }

        /// <summary>
        /// The InitializedObjectValue.
        /// </summary>
        internal void InitializedObjectValue()
        {
            this.room_id = 0;
            this.guest_id = 0;
            this.checkin_date = DateTime.Now;
            this.checkout_date = DateTime.Now;
            this.created_date = DateTime.Now;
            this.updated_date = DateTime.Now;
            this.is_deleted = 0;
        }
    }
}
