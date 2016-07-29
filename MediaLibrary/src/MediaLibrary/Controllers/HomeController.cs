using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Entities.Entities;
using MediaLibrary.Models;

namespace MediaLibrary.Controllers
{
    //[Route("api/[controller]")]
    public class HomeController : Controller
    {
        private List<Phone> _phones = new List<Phone>
        {
            new Phone {Id = 1, Name = "one", Description = "onetest" },
            new Phone {Id = 2, Name = "two", Description = "twotest" },
            new Phone {Id = 3, Name = "three", Description = "threetest" },
            new Phone {Id = 4, Name = "four", Description = "fourtest" },
            new Phone {Id = 5, Name = "five", Description = "fivetest" },
            new Phone {Id = 6, Name = "Six", Description = "Sixtest" }
        };

        public IActionResult Index()
        {
            return View(_phones);
        }
        
        public JsonResult List()
        {
            return Json(_phones);
        }

        
        //public IActionResult Add(string str)  //need to create post request
        //{
        //    //_phones.Add((Phone)model);
        //    return Json(_phones);
        //}
    }
}
