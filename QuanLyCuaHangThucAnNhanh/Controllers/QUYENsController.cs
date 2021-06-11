using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyCuaHangThucAnNhanh.Models;

namespace QuanLyCuaHangThucAnNhanh.Controllers
{
    [Authorize(Roles = "admin")]
    public class QUYENsController : Controller
    {
        private QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities();

        // GET: QUYENs
        public ActionResult Index()
        {
            return View(db.QUYENs.ToList());
        }

        // GET: QUYENs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUYEN qUYEN = db.QUYENs.Find(id);
            if (qUYEN == null)
            {
                return HttpNotFound();
            }
            return View(qUYEN);
        }

        // GET: QUYENs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QUYENs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaQuyen,TenQuyen,GhiChu")] QUYEN qUYEN)
        {
            if (ModelState.IsValid)
            {
                db.QUYENs.Add(qUYEN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qUYEN);
        }

        // GET: QUYENs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUYEN qUYEN = db.QUYENs.Find(id);
            if (qUYEN == null)
            {
                return HttpNotFound();
            }
            return View(qUYEN);
        }

        // POST: QUYENs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaQuyen,TenQuyen,GhiChu")] QUYEN qUYEN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qUYEN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qUYEN);
        }

        // GET: QUYENs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUYEN qUYEN = db.QUYENs.Find(id);
            if (qUYEN == null)
            {
                return HttpNotFound();
            }
            return View(qUYEN);
        }

        // POST: QUYENs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QUYEN qUYEN = db.QUYENs.Find(id);
            db.QUYENs.Remove(qUYEN);
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
