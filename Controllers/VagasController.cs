using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Estacionamento.Entidades;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Estacionamento.Controllers
{
    [Authorize(AuthenticationSchemes = "CookieAuthentication")]
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

        // GET: VagasController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            VagaVeiculoViewModel vagaVeiculoViewModel = new VagaVeiculoViewModel();
            Vagas vaga = db.VAGAS.Where(v => v.Id == id).FirstOrDefault();
            List<Veiculos> veiculos = db.VEICULOS.ToList();
            vagaVeiculoViewModel.Veiculos = veiculos;
            vagaVeiculoViewModel.Vaga = vaga;
            return PartialView(vagaVeiculoViewModel);
        }

        // POST: VagasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckIn(VagaVeiculoViewModel collection)
        {
            collection.Vaga.Veiculo = db.VEICULOS.Where(veiculo => veiculo.Id == collection.Vaga.VeiculoId).FirstOrDefault();
            collection.Vaga.Status = "Ocupado";
            Vagas filteredCollection = collection.Vaga;
            try
            {
                db.VAGAS.Update(filteredCollection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckOut(VagaVeiculoViewModel collection)
        {
            Vagas vagaAtualizada = db.VAGAS.Where(a => a.Id == collection.Vaga.Id).FirstOrDefault();
            vagaAtualizada.Chegada = null;
            vagaAtualizada.Saida = null;
            vagaAtualizada.VeiculoId = null;
            vagaAtualizada.Veiculo = null;
            vagaAtualizada.Status = "Livre";
            try
            {
                db.VAGAS.Update(vagaAtualizada);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
