using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingLot.DB;
using ParkingLot.Models;

namespace ParkingLot.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            var context = new AppPruebaContext();
            return View();
        }

        [HttpPost]
        public ActionResult Crear(User user)
        {
            var context = new AppPruebaContext();
            
            if (ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Home");
            }

            return View("Register");

        }
    }
}
