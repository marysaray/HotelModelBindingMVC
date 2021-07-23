using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using HotelModelBindingMVC.Models;

namespace HotelModelBindingMVC.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet] // associated with the nav-link URL
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // retireve data after submission
        public IActionResult Add(IFormCollection form)
        {
            // TODO: server-side valdiation for all data

            // extract data: create new instance of RSVP object
            RSVP req = new RSVP();
            req.FirstName = form["first-name"];
            req.LastName = form["last-name"];
            req.PhoneNumber = form["phone"];
            req.Email = form["email"];
            req.Date = Convert.ToDateTime(form["date"]); // convert to datetime

            // Add customer to database

            // display message if form has been submitted and hide form.
            ViewData["Submit"] = $"Thank you, " + req.FirstName + " " +  req.LastName +
                " for your RSVP! Please check your email for confirmation.";

            return View();
        }
    }
}
