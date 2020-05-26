using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Extensions;
using Parking_Lot.DB;
using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Parking_Lot.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            var context = new AppPruebaContext();

                var user = context.Users.FirstOrDefault(o => o.Email == email && o.Password == password);

            if (user == null)
                return View();

            //Guarda en memoria cache
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Email)
            };
            HttpContext.Session.Set("SessionLoggedUser", user);

            var userIdentity = new ClaimsIdentity(claims, "login");
            var principal = new ClaimsPrincipal(userIdentity);

            HttpContext.SignInAsync(principal);

            return RedirectToAction("Final", "Inicio");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
