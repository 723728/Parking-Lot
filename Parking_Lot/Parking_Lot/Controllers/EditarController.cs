using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parking_Lot.DB;
using Parking_Lot.Models;

namespace Parking_Lot.Controllers
{
    public class EditarController : Controller
    {
        
        [HttpGet]
        public ViewResult Index(int id)
        {
            var context = new AppPruebaContext();
            var user = context.Users.Where(o => o.Id == id).First();
            return View(user);
        }


        [HttpPost]
        public RedirectToActionResult Index(User user)
        {
            var context = new AppPruebaContext();
            var userDb = context.Users.Where(o => o.Id == user.Id).First();

            userDb.FirstName = user.FirstName;
            userDb.LastName = user.LastName;
            userDb.Date = user.Date;
            userDb.Genero = user.Genero;

            context.SaveChanges();

            return RedirectToAction();
        }
        
    }
}
