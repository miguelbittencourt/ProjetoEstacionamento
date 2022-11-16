﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Estacionamento.Entidades;
using Microsoft.AspNetCore.Authorization;

namespace Estacionamento.Controllers
{
    [Authorize(AuthenticationSchemes = "CookieAuthentication")]
    public class UsuariosController : Controller
    {
        private readonly Contexto db;

        public UsuariosController(Contexto contexto)
        {
            db = contexto;
        }


        // GET: UsuariosController
        public ActionResult Index(string query, string tipoPesquisa)
        {
            switch (tipoPesquisa)
            {
                case "Nome":
                    return View(db.USUARIOS.Where(a => a.Nome.Contains(query)));
                case "Login":
                    return View(db.USUARIOS.Where(a => a.Login.Contains(query)));
                case "Todos":
                    return View(db.USUARIOS.Where(a => a.Nome.Contains(query) || a.Login.Contains(query)));
                default:
                    return View(db.USUARIOS.ToList());
            }
        }

        public ActionResult RemoverFiltros()
        {
            return RedirectToAction("Index", "Usuarios");
        }

        public ActionResult Delete(int id)
        {
            db.USUARIOS.Remove(db.USUARIOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuarios collection)
        {
            try
            {
                db.USUARIOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.USUARIOS.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuarios collection)
        {
            try
            {
                db.USUARIOS.Update(collection);
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
