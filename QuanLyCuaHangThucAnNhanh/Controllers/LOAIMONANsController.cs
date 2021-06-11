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
    [Authorize(Roles = "true")]
    public class LOAIMONANsController : Controller
    {
        private QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities();

        // GET: LOAIMONANs
        public ActionResult Index()
        {
            return View(db.LOAIMONANs.ToList());
        }

        // GET: LOAIMONANs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIMONAN lOAIMONAN = db.LOAIMONANs.Find(id);
            if (lOAIMONAN == null)
            {
                return HttpNotFound();
            }
            return View(lOAIMONAN);
        }

        // GET: LOAIMONANs/Create
        public ActionResult Create()
        {
            LOAIMONAN tk = new LOAIMONAN();
            var tksau = db.LOAIMONANs.OrderByDescending(c => c.MaLoaiMonAn).FirstOrDefault();
            if (tksau == null)
            {
                tk.MaLoaiMonAn = 1;
            }
            else
            {
                tk.MaLoaiMonAn = tksau.MaLoaiMonAn + 1;
            }
            return View(tk);
        }

        // POST: LOAIMONANs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiMonAn,TenLoaiMonAN")] LOAIMONAN lOAIMONAN)
        {
            if (ModelState.IsValid)
            {
                db.LOAIMONANs.Add(lOAIMONAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lOAIMONAN);
        }

        // GET: LOAIMONANs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIMONAN lOAIMONAN = db.LOAIMONANs.Find(id);
            if (lOAIMONAN == null)
            {
                return HttpNotFound();
            }
            return View(lOAIMONAN);
        }

        // POST: LOAIMONANs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiMonAn,TenLoaiMonAN")] LOAIMONAN lOAIMONAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lOAIMONAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lOAIMONAN);
        }

        // GET: LOAIMONANs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIMONAN lOAIMONAN = db.LOAIMONANs.Find(id);
            if (lOAIMONAN == null)
            {
                return HttpNotFound();
            }
            return View(lOAIMONAN);
        }

        // POST: LOAIMONANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LOAIMONAN lOAIMONAN = db.LOAIMONANs.Find(id);
            db.LOAIMONANs.Remove(lOAIMONAN);
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
