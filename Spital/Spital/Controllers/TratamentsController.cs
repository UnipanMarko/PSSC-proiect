using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Spital.Models;

namespace Spital.Controllers
{
    public class TratamentsController : Controller
    {
        private SpitalContext db = new SpitalContext();

        // GET: Trataments
        public ActionResult Index()
        {
            return View(db.Trataments.ToList());
        }

        // GET: Trataments/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tratament tratament = db.Trataments.Find(id);
            if (tratament == null)
            {
                return HttpNotFound();
            }
            return View(tratament);
        }

        // GET: Trataments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trataments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTratament,Nume")] Tratament tratament)
        {
            if (ModelState.IsValid)
            {
                tratament.IdTratament = Guid.NewGuid();
                db.Trataments.Add(tratament);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tratament);
        }

        // GET: Trataments/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tratament tratament = db.Trataments.Find(id);
            if (tratament == null)
            {
                return HttpNotFound();
            }
            return View(tratament);
        }

        // POST: Trataments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTratament,Nume")] Tratament tratament)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tratament).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tratament);
        }

        // GET: Trataments/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tratament tratament = db.Trataments.Find(id);
            if (tratament == null)
            {
                return HttpNotFound();
            }
            return View(tratament);
        }

        // POST: Trataments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Tratament tratament = db.Trataments.Find(id);
            db.Trataments.Remove(tratament);
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
