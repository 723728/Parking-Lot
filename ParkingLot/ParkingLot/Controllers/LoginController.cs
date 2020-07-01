using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Extensions;
using ParkingLot.DB;
using ParkingLot.Models;

namespace ParkingLot.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Inicio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Inicio(string email, string password)
        {
            var context = new AppPruebaContext();

            var user = context.Users.FirstOrDefault(o => o.Email == email && o.Password == password);
            
            if (user == null)
                return View();


            return RedirectToAction("Recovery", "Recovery");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Inicio", "Login");
        }
    }
}
