using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parking_Lot.DB;
using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Parking_Lot.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ViewResult Prueba()
        {
            var context = new AppPruebaContext();
            var users = context.Users.ToList();
            return View(users);
        }


        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            var context = new AppPruebaContext();

            if (ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Prueba");
            }

            return View("Index");
        }
    }
}
