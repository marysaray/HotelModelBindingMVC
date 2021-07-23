using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelModelBindingMVC.Models
{
    /// <summary>
    /// Represents one customer reservation
    /// </summary>
    public class RSVP
    {
        /// <summary>
        /// The legal customer first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The legal customer last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Contact phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Contact email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// the day form was submitted
        /// </summary>
        public DateTime Date { get; set; }
    }
}
