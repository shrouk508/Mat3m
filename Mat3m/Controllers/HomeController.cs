using Mat3m.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3m.Controllers
{
    public class HomeController : Controller
    {
        Mat3amContext mat3;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,Mat3amContext mat3Am)
        {
            _logger = logger;
            mat3 = mat3Am;
        }

        public IActionResult Index()
        {
            var K = mat3.Offer.ToList();
            return View(K);
        }

        public IActionResult Order()
        {
           
            return View();
        }

        public IActionResult Supply()
        {

            return View();
        }

     

        public IActionResult Items()
        {
            var K = mat3.Itesm.ToList();
            return View(K);
        }

        public IActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BookingService(Booking modle)
        {
            if (ModelState.IsValid)
            {
                mat3.Booking.Add(modle);
                mat3.SaveChanges();
                return RedirectToAction("Index");

            }
            return View("Book",modle);
        }


        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendComment(ContactUs modle)
        {
            if (ModelState.IsValid)
            {
                mat3.ContactUs.Add(modle);
                mat3.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("ContactUs",modle);
        }

        public IActionResult Orderdd(Order modle)
        {
            if (ModelState.IsValid)
            {
                mat3.Order.Add(modle);
                mat3.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Order", modle);
        }

        public IActionResult Save_Supplied(Supply modle)
        {
            if (ModelState.IsValid)
            {
                mat3.Supplies.Add(modle);
                mat3.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Order", modle);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
