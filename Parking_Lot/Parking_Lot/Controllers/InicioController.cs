using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Extensions;
using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking_Lot.Controllers
{
    [Authorize]
    public class InicioController : Controller
    {
        
        [HttpGet]
        public IActionResult Final()
        {
            return View();
        }


        [HttpGet]
        public string GetLoggedUser()
        {
            var loggedUser = HttpContext.Session.GetString("LoggedUser");
            return loggedUser;
        }
    }
}
