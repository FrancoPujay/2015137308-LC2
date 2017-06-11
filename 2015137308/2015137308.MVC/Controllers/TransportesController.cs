using System;
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
    public class TransportesController : Controller
    {
        private _2015137308DbContext db = new _2015137308DbContext();

        // GET: Transportes
        public ActionResult Index()
        {
            var transportes = db.Transportes.Include(t => t.Bus).Include(t => t.LugarViaje).Include(t => t.Cliente);
            return View(transportes.ToList());
        }

        // GET: Transportes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = db.Transportes.Find(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            return View(transporte);
        }

        // GET: Transportes/Create
        public ActionResult Create()
        {
            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa");
            ViewBag.LugarViajeId = new SelectList(db.LugarViajes, "LugarViajeId", "Descripcion");
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Dni");
            return View();
        }

        // POST: Transportes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioId,LugarViajeId,BusId,ClienteId,TipoViaje")] Transporte transporte)
        {
            if (ModelState.IsValid)
            {
                db.Transportes.Add(transporte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa", transporte.BusId);
            ViewBag.LugarViajeId = new SelectList(db.LugarViajes, "LugarViajeId", "Descripcion", transporte.LugarViajeId);
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Dni", transporte.ClienteId);
            return View(transporte);
        }

        // GET: Transportes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = db.Transportes.Find(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa", transporte.BusId);
            ViewBag.LugarViajeId = new SelectList(db.LugarViajes, "LugarViajeId", "Descripcion", transporte.LugarViajeId);
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Dni", transporte.ClienteId);
            return View(transporte);
        }

        // POST: Transportes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioId,LugarViajeId,BusId,ClienteId,TipoViaje")] Transporte transporte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transporte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa", transporte.BusId);
            ViewBag.LugarViajeId = new SelectList(db.LugarViajes, "LugarViajeId", "Descripcion", transporte.LugarViajeId);
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Dni", transporte.ClienteId);
            return View(transporte);
        }

        // GET: Transportes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = db.Transportes.Find(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            return View(transporte);
        }

        // POST: Transportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transporte transporte = db.Transportes.Find(id);
            db.Transportes.Remove(transporte);
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
