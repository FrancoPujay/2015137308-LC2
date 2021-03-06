﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2015137308.Entities.Entities;
using _2015137308.Persistence;

namespace _2015137308.MVC.Controllers
{
    public class EncomiendasController : Controller
    {
        private _2015137308DbContext db = new _2015137308DbContext();

        // GET: Encomiendas
        public ActionResult Index()
        {
            var encomiendas = db.Encomiendas.Include(e => e.Bus).Include(e => e.LugarViaje);
            return View(encomiendas.ToList());
        }

        // GET: Encomiendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomienda encomienda = db.Encomiendas.Find(id);
            if (encomienda == null)
            {
                return HttpNotFound();
            }
            return View(encomienda);
        }

        // GET: Encomiendas/Create
        public ActionResult Create()
        {
            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa");
            ViewBag.LugarViajeId = new SelectList(db.LugarViajes, "LugarViajeId", "Descripcion");
            return View();
        }

        // POST: Encomiendas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioId,LugarViajeId,BusId,Beneficiario,Peso")] Encomienda encomienda)
        {
            if (ModelState.IsValid)
            {
                db.Encomiendas.Add(encomienda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa", encomienda.BusId);
            ViewBag.LugarViajeId = new SelectList(db.LugarViajes, "LugarViajeId", "Descripcion", encomienda.LugarViajeId);
            return View(encomienda);
        }

        // GET: Encomiendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomienda encomienda = db.Encomiendas.Find(id);
            if (encomienda == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa", encomienda.BusId);
            ViewBag.LugarViajeId = new SelectList(db.LugarViajes, "LugarViajeId", "Descripcion", encomienda.LugarViajeId);
            return View(encomienda);
        }

        // POST: Encomiendas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioId,LugarViajeId,BusId,Beneficiario,Peso")] Encomienda encomienda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encomienda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa", encomienda.BusId);
            ViewBag.LugarViajeId = new SelectList(db.LugarViajes, "LugarViajeId", "Descripcion", encomienda.LugarViajeId);
            return View(encomienda);
        }

        // GET: Encomiendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomienda encomienda = db.Encomiendas.Find(id);
            if (encomienda == null)
            {
                return HttpNotFound();
            }
            return View(encomienda);
        }

        // POST: Encomiendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Encomienda encomienda = db.Encomiendas.Find(id);
            db.Encomiendas.Remove(encomienda);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
