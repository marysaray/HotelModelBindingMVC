using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelModelBindingMVC.Models
{
    /// <summary>
    /// Represents one Hotel.
    /// </summary>
    public class Hotel
    {
        /// <summary>
        /// Represents the Hotel Name.
        /// </summary>
        public string HotelName { get; set; }

        /// <summary>
        /// Total rooms in the Hotel.
        /// </summary>
        public int Rooms { get; set; }

        /// <summary>
        /// Total booked rooms in the Hotel.
        /// </summary>
        public int Booked { get; set; }

        /// <summary>
        /// Returns amount of room available.
        /// </summary>
        /// <returns></returns>
        public int CheckAvailability()
        {
            return this.Rooms - this.Booked;
        }
    }
}