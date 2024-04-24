using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.Admin
{
    public class AdminEntity
    {

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the role of the user.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets whether the user is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntity"/> class.
        /// </summary>
        public AdminEntity()
        {
            InitializedObjectValue();
        }

        /// <summary>
        /// Initializes the default values for object properties.
        /// </summary>
        internal void InitializedObjectValue()
        {
            UserId = 0;
            Username = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            IsDeleted = false;
        }
    }
}
