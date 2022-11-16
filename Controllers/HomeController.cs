﻿using Estacionamento.Entidades;
using Estacionamento.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Controllers
{
    [Authorize(AuthenticationSchemes = "CookieAuthentication")]
    public class HomeController : Controller
    {
        private readonly Contexto db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Contexto contexto)
        {
            _logger = logger;
            db = contexto;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Vagas");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
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
