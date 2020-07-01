using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingLot.Models;

namespace ParkingLot.Controllers
{
    public class HomeController : Controller
    {
        //LLamar la Pagina Principal
        public IActionResult Index()
        {
            return View("Index");
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
