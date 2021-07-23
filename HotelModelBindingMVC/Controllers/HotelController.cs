using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using HotelModelBindingMVC.Models;

namespace HotelModelBindingMVC.Controllers
{
    public class HotelController : Controller
    {
        // Add hotel to database: attribute are placed above the method with []

        [HttpGet] // navigates to form linked to URL
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // retrieve data after submission: get data from the server
        public IActionResult Add(IFormCollection form)
        {
            // extract data: create new instance of hotel object
            Hotel hotel = new Hotel();
            hotel.HotelName = form["hotel-name"];

            return View();
        }
    }
}