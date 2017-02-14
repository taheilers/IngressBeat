using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IngressBeat.Models;

namespace IngressBeat.Controllers
{
    public class PortalsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Portals
        public ActionResult Index()
        {
            return View(db.Portals.ToList());
        }

        // GET: Portals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portal portal = db.Portals.Find(id);
            if (portal == null)
            {
                return HttpNotFound();
            }
            return View(portal);
        }

        // GET: Portals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Portals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PortalName,PLat,PLong,Captured,Faction")] Portal portal)
        {
            if (ModelState.IsValid)
            {
                db.Portals.Add(portal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(portal);
        }

        // GET: Portals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portal portal = db.Portals.Find(id);
            if (portal == null)
            {
                return HttpNotFound();
            }
            return View(portal);
        }

        // POST: Portals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PortalName,PLat,PLong,Captured,Faction")] Portal portal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(portal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(portal);
        }

        // GET: Portals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portal portal = db.Portals.Find(id);
            if (portal == null)
            {
                return HttpNotFound();
            }
            return View(portal);
        }

        // POST: Portals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Portal portal = db.Portals.Find(id);
            db.Portals.Remove(portal);
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
