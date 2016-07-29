using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngularTestRunApp.Models;

namespace AngularTestRunApp.Controllers
{
    public class HomeController : Controller
    {
        private AppDBContext _db;

        public HomeController(AppDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.PhoneId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            _db.Orders.Add(order);
            // сохраняем в бд все изменения
            _db.SaveChanges();
            return "Спасибо, " + order.User + ", за покупку!";
        }

    }
}
