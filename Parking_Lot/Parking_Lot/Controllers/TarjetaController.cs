using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.Extensions;
using Parking_Lot.DB;
using Parking_Lot.Models;

namespace Parking_Lot.Controllers
{
    public class TarjetaController : Controller
    {
        [HttpGet]
        public string GetLoggedUser()
        {
            var loggedUser = HttpContext.Session.GetString("LoggedUser");
            return loggedUser;
        }

        [HttpGet]
        public IActionResult Index(string query)
        {
            var usserLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var context = new AppPruebaContext();
            
            var model = context.Tarjetas
                .Include(o => o.User)
                .Where(o => o.Id_Usuario == usserLogged.Id)
                .ToList();
            
            ViewBag.Query = query;
            return View(model);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            var context = new AppPruebaContext();
            ViewBag.Categorias = context.Tarjetas.ToList();
            var tarjeta = new Tarjeta();
            return View(tarjeta);
        }

        [HttpPost]
        public IActionResult Crear(Tarjeta tarjeta)
        {
            var usserLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var context = new AppPruebaContext();

            tarjeta.Id_Usuario = usserLogged.Id;
            context.Tarjetas.Add(tarjeta);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Borrar(int id)
        {
            var context = new AppPruebaContext();
            var productoDb = context.Tarjetas.Where(o => o.Id == id).First();

            context.Tarjetas.Remove(productoDb);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        
    }
}
