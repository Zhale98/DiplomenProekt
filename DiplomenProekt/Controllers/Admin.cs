using DiplomenProekt.Data;
using DiplomenProekt.Data.DbModels;
using DiplomenProekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomenProekt.Controllers
{
    public class Admin : Controller
    {
        private readonly ApplicationDbContext context;

        public Admin(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult AddLeglo()
        {

            return View();

        }
        public IActionResult ListLegla()
        {
            List<Vid_leglo> model = context.Vidove_Legla.ToList();
            return View(model);
        }
        public IActionResult EditLeglo(int id)
        {
            Vid_leglo model = context.Vidove_Legla.Find(id);

            return View(model);
        }
        public IActionResult AddReservation()
        {

            return View();
        }
        public IActionResult ListReservacii()
        {
            List<Rezervacii> model = context.Rezervacii.ToList();
            return View(model);
        }
        public IActionResult EditReservation(int id)
        {
            Rezervacii model = context.Rezervacii.Find(id);

            return View(model);
        }
        public IActionResult AddSmqna()
        {

            return View();
        }
        public IActionResult ListSmqna()
        {
            List<Smqna> model = context.Smeni.ToList();

            return View(model);
        }
        public IActionResult EditSmqna(int id)
        {
            Smqna model = context.Smeni.Find(id);

            return View(model);
        }
        [HttpPost]
        public IActionResult AddLeglo(Vid_leglo model)
        {
            context.Vidove_Legla.Add(model);
            context.SaveChanges();
            return RedirectToAction("ListLegla");

        }
        [HttpPost]
        public IActionResult AddReservation(Rezervacii model)
        {
            context.Rezervacii.Add(model);
            context.SaveChanges();
            return RedirectToAction("ListReservacii");
        }
        [HttpPost]
        public IActionResult AddSmqna(Smqna model)
        {
            context.Smeni.Add(model);
            context.SaveChanges();
            return RedirectToAction("ListSmqna");
        }
    }
}
