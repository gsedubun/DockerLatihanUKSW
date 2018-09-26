﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Latihan.Web.Models;

using Latihan.Data;

namespace Latihan.Web.Controllers
{
    public class HomeController : Controller
    {
        private DataAccess da;

        public HomeController(DataAccess dataaccess)
        {
            this.da = dataaccess;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(da);
        }

        [HttpPost]
        public IActionResult Index(TabelUser tabelUser){
            da.InsertUser(tabelUser);
            return View(da);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
