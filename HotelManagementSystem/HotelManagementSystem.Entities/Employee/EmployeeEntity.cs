using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.Employee
{
    public class EmployeeEntity
    {
        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public int employeeId { get; set; }


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
        /// Gets or sets the position.
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// Gets or sets the NRC number.
        /// </summary>
        public string nrcNumber { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        public DateTime dob { get; set; }

        /// <summary>
        /// Gets or sets the joined dated.
        /// </summary>
        public DateTime joinedDate { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        public string image { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Gets or sets the is deleted.
        /// </summary>
        public short is_deleted { get; set; }

        /// <summary>
        /// Gets or sets the created user id.
        /// </summary>
        public int createdUserId { get; set; }

        /// <summary>
        /// Gets or sets the updated user id.
        /// </summary>
        public int updatedUserId { get; set; }

        /// <summary>
        /// Gets or sets the deleted user id.
        /// </summary>
        public int deletedUserId { get; set; }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        public System.DateTime createdDateTime { get; set; }

        /// <summary>
        /// Gets or sets the updated date time.
        /// </summary>
        public System.DateTime updatedDateTime { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeEntity"/> class.
        /// </summary>
        public EmployeeEntity()
        {
            InitializedObjectValue();
        }

        /// <summary>
        /// The InitializedObjectValue.
        /// </summary>
        internal void InitializedObjectValue()
        {
            this.employeeId = 0;
            this.fullName = string.Empty;
            this.phoneNumber = string.Empty;
            this.gender = 0;
            this.position = string.Empty;
            this.nrcNumber = string.Empty;
            this.dob = DateTime.Now;
            this.joinedDate = DateTime.Now;
            this.image = string.Empty;
            this.address = string.Empty;
            this.is_deleted = 0;
            this.createdDateTime = DateTime.Now;
            this.updatedDateTime = DateTime.Now;
            this.createdUserId = 0;
            this.updatedUserId = 0;
            this.deletedUserId = 0;
        }
    }
}
