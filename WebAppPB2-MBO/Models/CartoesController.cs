using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebAppPB2_MBO.Models
{
    public class CartoesController : Controller
    {
        private CartaoContext db = new CartaoContext();

        // GET: Cartoes
        public ActionResult Index()
        {
            return View(db.CartaoDeCreditoes.ToList());
        }

        // GET: Cartoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartaoDeCredito cartaoDeCredito = db.CartaoDeCreditoes.Find(id);
            if (cartaoDeCredito == null)
            {
                return HttpNotFound();
            }
            return View(cartaoDeCredito);
        }

        // GET: Cartoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cartoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Numero,Cliente")] CartaoDeCredito cartaoDeCredito)
        {
            if (ModelState.IsValid)
            {
                db.CartaoDeCreditoes.Add(cartaoDeCredito);
                db.SaveChanges();
                TempData["Mensagem"] = "Cartão cadastrado com sucesso!";
                return RedirectToAction("Index");
            }

            return View(cartaoDeCredito);
        }

        // GET: Cartoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartaoDeCredito cartaoDeCredito = db.CartaoDeCreditoes.Find(id);
            if (cartaoDeCredito == null)
            {
                return HttpNotFound();
            }
            return View(cartaoDeCredito);
        }

        // POST: Cartoes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Numero,Cliente")] CartaoDeCredito cartaoDeCredito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cartaoDeCredito).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Mensagem"] = "Cartão editada com sucesso!";
                return RedirectToAction("Index");
            }
            return View(cartaoDeCredito);
        }

        // GET: Cartoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartaoDeCredito cartaoDeCredito = db.CartaoDeCreditoes.Find(id);
            if (cartaoDeCredito == null)
            {
                return HttpNotFound();
            }
            return View(cartaoDeCredito);
        }

        // POST: Cartoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CartaoDeCredito cartaoDeCredito = db.CartaoDeCreditoes.Find(id);
            db.CartaoDeCreditoes.Remove(cartaoDeCredito);
            db.SaveChanges();
            TempData["Mensagem"] = "Cartão excluída com sucesso!";
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
