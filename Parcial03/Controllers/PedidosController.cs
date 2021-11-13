using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Parcial03.Models;

namespace Parcial03.Controllers
{
    public class PedidosController : Controller
    {
        private Parcial03DSS db = new Parcial03DSS();

        // GET: Pedidos
        public ActionResult Index()
        {
            var pedidos = db.pedidos.Include(p => p.clientes).Include(p => p.productos);
            return View(pedidos.ToList());
        }

        // GET: Pedidos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedidos pedidos = db.pedidos.Find(id);
            if (pedidos == null)
            {
                return HttpNotFound();
            }
            return View(pedidos);
        }

        // GET: Pedidos/Create
        public ActionResult Create()
        {
            ViewBag.id_Clie = new SelectList(db.clientes, "id_Clie", "nombres");
            ViewBag.id_Pro = new SelectList(db.productos, "id_Pro", "nombre");
            return View();
        }

        // POST: Pedidos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,fechaPedido,fechaEntrega,id_Pro,id_Clie")] Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                db.pedidos.Add(pedidos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_Clie = new SelectList(db.clientes, "id_Clie", "nombres", pedidos.id_Clie);
            ViewBag.id_Pro = new SelectList(db.productos, "id_Pro", "nombre", pedidos.id_Pro);
            return View(pedidos);
        }

        // GET: Pedidos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedidos pedidos = db.pedidos.Find(id);
            if (pedidos == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_Clie = new SelectList(db.clientes, "id_Clie", "nombres", pedidos.id_Clie);
            ViewBag.id_Pro = new SelectList(db.productos, "id_Pro", "nombre", pedidos.id_Pro);
            return View(pedidos);
        }
        public Int32 agregar(Pedidos pro)
        {
            try
            {
                //El error cuando es vacio el id es 0
                //si es exito es 1
                var lista = Pedidos.listar();
                if(pro.id == default)
                {
                    return 1;
                }
                if (pro.id_Pro == default)
                {
                    return 2;
                }
                if (pro.id_Clie == default)
                {
                    //Si el nombre no se parece a ese va dar 2
                    return 3;
                }
             
                
                lista.Add(pro);

                return 0;
            }
            catch
            {
                return 1;
            }
        }

        // POST: Pedidos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,fechaPedido,fechaEntrega,id_Pro,id_Clie")] Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedidos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_Clie = new SelectList(db.clientes, "id_Clie", "nombres", pedidos.id_Clie);
            ViewBag.id_Pro = new SelectList(db.productos, "id_Pro", "nombre", pedidos.id_Pro);
            return View(pedidos);
        }

        // GET: Pedidos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedidos pedidos = db.pedidos.Find(id);
            if (pedidos == null)
            {
                return HttpNotFound();
            }
            return View(pedidos);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pedidos pedidos = db.pedidos.Find(id);
            db.pedidos.Remove(pedidos);
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
