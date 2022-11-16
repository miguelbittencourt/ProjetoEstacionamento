using Estacionamento.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Estacionamento.Controllers
{
    [Authorize(AuthenticationSchemes = "CookieAuthentication")]
    public class VeiculosController : Controller
    {
        private readonly Contexto db;
        public VeiculosController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: VeiculosController
        public ActionResult Index()
        {
            return View(db.VEICULOS.ToList());
        }

        // GET: VeiculosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.VEICULOS.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: VeiculosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Veiculos collection)
        {
            try
            {
                db.VEICULOS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VeiculosController/Delete/5
        public ActionResult Delete(int id)
        {
            db.VEICULOS.Remove(db.VEICULOS.Where(a=> a.Id == id).FirstOrDefault ());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: VeiculosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VeiculosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Veiculos collection)
        {
            try
            {
                db.VEICULOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
