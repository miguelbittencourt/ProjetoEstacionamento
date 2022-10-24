using Estacionamento.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Estacionamento.Controllers
{
    public class UsuariosController : Controller
    {
        public static List<Usuario> lsUsuarios = new List<Usuario>();
        public IActionResult Index()
        {
            return View(lsUsuarios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Usuario objeto)
        {
            lsUsuarios.Add(objeto);
            return RedirectToAction("Index");
        }
    }
}
