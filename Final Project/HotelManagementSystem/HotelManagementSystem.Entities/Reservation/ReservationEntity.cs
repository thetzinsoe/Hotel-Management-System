using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.Reservation
{
    public class ReservationEntity
    { 
        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public int reservation_id { get; set; }

        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public int room_id { get; set; }


        /// <summary>
        /// Gets or Sets name
        /// </summary>
        public string room_number { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public DateTime checkin_date { get; set; }

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        public DateTime checkout_date { get; set; }

        /// <summary>
        /// Gets or Sets customer_name
        /// </summary>
        public string customer_name { get; set; }

        /// <summary>
        /// Gets or Sets customer_name
        /// </summary>
        public string customer_phoneNo { get; set; }

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
        public ReservationEntity()
        {
            InitializedObjectValue();
        }

        /// <summary>
        /// The InitializedObjectValue.
        /// </summary>
        internal void InitializedObjectValue()
        {
            this.reservation_id = 0;
            this.room_id = 0;
            this.room_number = String.Empty;
            this.checkin_date = DateTime.Now;
            this.checkout_date = DateTime.Now;
            this.customer_name = String.Empty;
            this.customer_phoneNo = String.Empty;
            this.created_date = DateTime.Now;
            this.updated_date = DateTime.Now;
            this.is_deleted = 0;
        }
    }
}
