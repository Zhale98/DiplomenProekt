using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomenProekt.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Rezervacii()
        {
            return View();
        }
        public IActionResult Registur()
        {
            return View();
        }
        public IActionResult Spravka()
        {
            return View();
        }
        public IActionResult Arhiv()
        {
            return View();
        }
        public IActionResult Opis()
        {
            return View();
        }
        public IActionResult Cenorazpis()
        {
            return View();
        }
        public IActionResult Akaunti()
        {
            return View();
        }
        public IActionResult Nastroyki()
        {
            return View();
        }

    }
}
