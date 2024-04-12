using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.Guest
{
    public class GuestEntity
    {
        /// <summary>
        /// Gets or sets the guest id.
        /// </summary>
        public int guestId { get; set; }


        /// <summary>
        /// Gets or Sets full name.
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        public short gender { get; set; }

        /// <summary>
        /// Gets or sets the nationality.
        /// </summary>
        public string nationality { get; set; }

        /// <summary>
        /// Gets or sets the NRC number.
        /// </summary>
        public string nrcNumber { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        public DateTime dob { get; set; }


        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Gets or sets the is deleted.
        /// </summary>
        public short is_deleted { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public System.DateTime createdDate { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        public System.DateTime updatedDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestEntity"/> class.
        /// </summary>
        public GuestEntity()
        {
            InitializedObjectValue();
        }

        /// <summary>
        /// The InitializedObjectValue.
        /// </summary>
        internal void InitializedObjectValue()
        {
            this.guestId = 0;
            this.fullName = string.Empty;
            this.phoneNumber = string.Empty;
            this.gender = 0;
            this.nationality = string.Empty;
            this.nrcNumber = string.Empty;
            this.dob = DateTime.Now;
            this.address = string.Empty;
            this.is_deleted = 0;
            this.createdDate = DateTime.Now;
            this.updatedDate = DateTime.Now;
        }
    }
}
