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
    public class VentasController : Controller
    {
        private _2015137308DbContext db = new _2015137308DbContext();

        // GET: Ventas
        public ActionResult Index()
        {
            var ventas = db.Ventas.Include(v => v.Administrativo).Include(v => v.Cliente).Include(v => v.Servicio);
            return View(ventas.ToList());
        }

        // GET: Ventas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta venta = db.Ventas.Find(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            return View(venta);
        }

        // GET: Ventas/Create
        public ActionResult Create()
        {
            ViewBag.EmpleadoId = new SelectList(db.Empleados, "EmpleadoId", "Dni");
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Dni");
            ViewBag.VentaId = new SelectList(db.Servicios, "ServicioId", "ServicioId");
            return View();
        }

        // POST: Ventas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VentaId,EmpleadoId,ClienteId,TipoComprobante,TipoPago")] Venta venta)
        {
            if (ModelState.IsValid)
            {
                db.Ventas.Add(venta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmpleadoId = new SelectList(db.Empleados, "EmpleadoId", "Dni", venta.EmpleadoId);
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Dni", venta.ClienteId);
            ViewBag.VentaId = new SelectList(db.Servicios, "ServicioId", "ServicioId", venta.VentaId);
            return View(venta);
        }

        // GET: Ventas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta venta = db.Ventas.Find(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpleadoId = new SelectList(db.Empleados, "EmpleadoId", "Dni", venta.EmpleadoId);
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Dni", venta.ClienteId);
            ViewBag.VentaId = new SelectList(db.Servicios, "ServicioId", "ServicioId", venta.VentaId);
            return View(venta);
        }

        // POST: Ventas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VentaId,EmpleadoId,ClienteId,TipoComprobante,TipoPago")] Venta venta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(venta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmpleadoId = new SelectList(db.Empleados, "EmpleadoId", "Dni", venta.EmpleadoId);
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Dni", venta.ClienteId);
            ViewBag.VentaId = new SelectList(db.Servicios, "ServicioId", "ServicioId", venta.VentaId);
            return View(venta);
        }

        // GET: Ventas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta venta = db.Ventas.Find(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            return View(venta);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Venta venta = db.Ventas.Find(id);
            db.Ventas.Remove(venta);
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
