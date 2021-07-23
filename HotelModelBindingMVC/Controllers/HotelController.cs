using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelModelBindingMVC.Controllers
{
    public class HotelController : Controller
    {
        // Add hotel to database
        public IActionResult Add()
        {
            return View();
        }
    }
}