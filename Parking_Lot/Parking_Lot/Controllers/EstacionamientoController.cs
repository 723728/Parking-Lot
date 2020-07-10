using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parking_Lot.DB;
using Parking_Lot.Extensions;
using Parking_Lot.Models;

namespace Parking_Lot.Controllers
{
    [Authorize]
    public class EstacionamientoController : Controller
    {
        
        private AppDbContext context;
        public EstacionamientoController() {
            context = new AppDbContext();
        }
        public IActionResult Index()
        {
            var usserLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var estacionamiento = context.Estacionamientos.ToList();
            ViewBag.Tarjeta = context.Tarjetas.Where(o => o.IdUser == usserLogged.Id).ToList();
            return View(estacionamiento);
        }
        [HttpPost]
        public IActionResult Reserva(Reserva reserva) 
        {
            var usserLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            reserva.IdUser = usserLogged.Id;
            context.Reservas.Add(reserva);
            context.SaveChanges();
            return RedirectToAction("Index","Menu");
        }
        [HttpPost]
        public IActionResult Pagar(Pago pago)
        {
            var usserLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            pago.IdUser = usserLogged.Id;
            pago.Fecha = DateTime.Now;
            if (pago.IdTarjeta==0 || pago.NHoras==0) {
                return RedirectToAction("Index", "Menu");
            }
            context.Pagos.Add(pago);
            context.SaveChanges();
            return RedirectToAction("Index", "Menu");
        }
    }
}