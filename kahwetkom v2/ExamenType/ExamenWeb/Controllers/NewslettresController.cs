using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;
using ExamenWeb.Models;
using Data;

namespace ExamenWeb.Controllers
{
    public class NewslettresController : Controller
    {
        private ExamenContext db = new ExamenContext();

        // GET: Newslettres
        public ActionResult Index()
        {
            var newslettres = db.Newslettres.Include(n => n.Userr);
            return View(newslettres.ToList());
        }

        // GET: Newslettres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Newslettre newslettre = db.Newslettres.Find(id);
            if (newslettre == null)
            {
                return HttpNotFound();
            }
            return View(newslettre);
        }


        public ActionResult CreateFront()
        {
            
            return View();
        }

 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFront([Bind(Include = "IdNewslettre,IdUser,MailUser,PhoneUser")] Newslettre newslettre)
        {
            if (ModelState.IsValid)
            {
                db.Newslettres.Add(newslettre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdUser = new SelectList(db.Users, "IdUser", "Nom", newslettre.IdUser);
            return View(newslettre);
        }

        // GET: Newslettres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Newslettre newslettre = db.Newslettres.Find(id);
            if (newslettre == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdUser = new SelectList(db.Users, "IdUser", "Nom", newslettre.IdUser);
            return View(newslettre);
        }

        // POST: Newslettres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdNewslettre,IdUser,MailUser,PhoneUser,status")] Newslettre newslettre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newslettre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdUser = new SelectList(db.Users, "IdUser", "Nom", newslettre.IdUser);
            return View(newslettre);
        }

        // GET: Newslettres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Newslettre newslettre = db.Newslettres.Find(id);
            if (newslettre == null)
            {
                return HttpNotFound();
            }
            return View(newslettre);
        }

        // POST: Newslettres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Newslettre newslettre = db.Newslettres.Find(id);
            db.Newslettres.Remove(newslettre);
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
