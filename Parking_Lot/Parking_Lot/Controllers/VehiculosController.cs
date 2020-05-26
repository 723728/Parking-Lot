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
    public class VehiculosController : Controller
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

            var model = context.Vehiculos
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
            ViewBag.Categorias = context.Vehiculos.ToList();
            var vehiculo = new Vehiculo();
            return View(vehiculo);
        }

        [HttpPost]
        public IActionResult Crear(Vehiculo vehiculo)
        {
            var usserLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var context = new AppPruebaContext();

            vehiculo.Id_Usuario = usserLogged.Id;
            context.Vehiculos.Add(vehiculo);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Borrar(int id)
        {
            var context = new AppPruebaContext();
            var productoDb = context.Vehiculos.Where(o => o.Id == id).First();

            context.Vehiculos.Remove(productoDb);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Editar(int id)
        {
            var context = new AppPruebaContext();
            var producto = context.Vehiculos.Where(o => o.Id == id).First();
            return View(producto);
        }

        [HttpPost]
        public RedirectToActionResult Editar(Vehiculo vehiculo)
        {
            var context = new AppPruebaContext();
            var productoDb = context.Vehiculos.Where(o => o.Id == vehiculo.Id).First();

            productoDb.Tipo = vehiculo.Tipo;
            productoDb.Color = vehiculo.Color;
            productoDb.Descripcion= vehiculo.Descripcion;
            productoDb.Marca = vehiculo.Marca;
            productoDb.Modelo = vehiculo.Modelo;

            context.SaveChanges();

            return RedirectToAction("Editar", new { id = vehiculo.Id });
        }
    }
}
