using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.Payment
{
    public class PaymentEntity
    {

        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public int payment_id { get; set; } 
        
        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public int checkin_id { get; set; }

        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public decimal room_fees { get; set; }

        /// <summary>
        /// Gets or Sets name
        /// </summary>
        public decimal extra_fees { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        public decimal discount { get; set; }
        
        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        public decimal total_fees { get; set; }
        
        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        public string payment_type { get; set; }

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
        public PaymentEntity()
        {
            InitializedObjectValue();
        }

        /// <summary>
        /// The InitializedObjectValue.
        /// </summary>
        internal void InitializedObjectValue()
        {
            this.payment_id = 0;
            this.checkin_id = 0;
            this.room_fees = 0;
            this.extra_fees = 0;
            this.description = string.Empty;
            this.discount = 0;
            this.total_fees = 0;
            this.payment_type = string.Empty;
            this.created_date = DateTime.Now;
            this.updated_date = DateTime.Now;
            this.is_deleted = 0;
        }
    }
}
