using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Estacionamento.Entidades;
using System.Linq;

namespace Estacionamento.Controllers
{
    public class VagasController : Controller
    {
        private readonly Contexto db;

        public VagasController(Contexto contexto)
        {
            db = contexto;
        }


        // GET: VagasController
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        // GET: VagasController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: VagasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VagasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VagasController/Edit/5
        public ActionResult Edit(int id)
        {
            return PartialView("_EditVagas",db.VAGAS.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: VagasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VagasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VagasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
