using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelModelBindingMVC.Models
{
    /// <summary>
    /// Represents one customer information for reservation
    /// </summary>
    public class RSVP
    {
        /// <summary>
        /// The legal customer first name
        /// </summary>
        [Display(Name ="First Name:")]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// The legal customer last name
        /// </summary>
        [Display(Name ="Last Name:")]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Contact phone number
        /// </summary>
        [Display(Name ="Phone Number:")]
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Contact email address
        /// </summary>
        [Display(Name ="Email:")]
        [DataType(DataType.EmailAddress)] // validation for email
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// the day form was submitted
        /// </summary>
        [Display(Name ="Date:")]
        [DataType(DataType.Date)] // without time
        public DateTime Date { get; set; }
    }
}
