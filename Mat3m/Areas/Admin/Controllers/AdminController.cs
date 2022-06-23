using Mat3m.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3m.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        Mat3amContext db;
        public AdminController(Mat3amContext mat3Am)
        {
            db = mat3Am;
        }
        public IActionResult Index()
        {
            int CT = db.Category.Count();
            int I = db.Itesm.Count();
            int O = db.Offer.Count();
            int Od = db.Order.Count();
            int CO = db.ContactUs.Count();
            int Tab = db.Booking.Count();
            var Result = new AdminNumbers
            {
                Cat = CT,
                Itm = I,
                OFR = O,
                ORD = Od,
                COM = CO,
                Table=Tab,

            };


            return View(Result);
        }
    }
    public class AdminNumbers
    {
        public int Cat { get; set; }
        public int Itm { get; set; }
        public int OFR { get; set; }
        public int ORD { get; set; }
        public int COM { get; set; }
        public int Table { get; set; }
    }
    public class Comentes
    {
        public string N { get; set; }
        public string E { get; set; }
        public string T { get; set; }
        public string M { get; set; }
    }
}
