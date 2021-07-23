using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name ="First Name:")]
        public string FirstName { get; set; }

        /// <summary>
        /// The legal customer last name
        /// </summary>
        [Display(Name ="Last Name:")]
        public string LastName { get; set; }

        /// <summary>
        /// Contact phone number
        /// </summary>
        [Display(Name ="Phone Number:")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Contact email address
        /// </summary>
        [Display(Name ="Email:")]
        public string Email { get; set; }

        /// <summary>
        /// the day form was submitted
        /// </summary>
        [Display(Name ="Date:")]
        public DateTime Date { get; set; }
    }
}
