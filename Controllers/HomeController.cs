using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorkFinder.Models;

namespace WorkFinder.Controllers
{
    public class HomeController : Controller
    {
        private WorkFinderContext db;

        public HomeController(WorkFinderContext context)
        {
            this.db = context;
        }

        public IActionResult Index()
        {
            ViewBag.T = db.Clients.Find(1);
           // db.Clients.Find(1).Name = "CName1";
           // db.SaveChanges();
            ViewBag.A = db.Clients.Find(1);
            return View();
        }

    }
}
