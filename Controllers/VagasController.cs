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
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.VAGAS.ToList());
        }

        // GET: VagasController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: VagasController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: VagasController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            VagaVeiculoViewModel vagaVeiculoViewModel = new VagaVeiculoViewModel();
            Vagas vagas = db.VAGAS.Where(v => v.Id == id).FirstOrDefault();
            if (vagas.VeiculoId != null)
            {
                Veiculos veiculo = db.VEICULOS.Where(v => v.Id == vagas.VeiculoId).FirstOrDefault();
                vagaVeiculoViewModel.Veiculo = veiculo;
            }
            vagaVeiculoViewModel.Vagas = vagas;
            return PartialView(vagaVeiculoViewModel);
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
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: VagasController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
