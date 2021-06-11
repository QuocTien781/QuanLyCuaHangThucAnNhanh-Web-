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
    public class HDsController : Controller
    {
        private QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities();

        // GET: HDs
        public ActionResult Index()
        {
           
            return View(db.HDs.ToList());
        }

        // GET: HDs/Details/5
        

        // GET: HDs/Create
        public ActionResult Create()
        {
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "HoNhanVien");
            return View();
        }

        // POST: HDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHD,MaNhanVien,ThoiGian")] HD HD)
        {
            if (ModelState.IsValid)
            {
                db.HDs.Add(HD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "HoNhanVien", HD.MaNhanVien);
            return View(HD);
        }

        // GET: HDs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HD HD = db.HDs.Find(id);
            if (HD == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "HoNhanVien", HD.MaNhanVien);
            return View(HD);
        }

        // POST: HDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHD,MaNhanVien,ThoiGian")] HD HD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(HD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "HoNhanVien", HD.MaNhanVien);
            return View(HD);
        }

        // GET: HDs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HD HD = db.HDs.Find(id);
            if (HD == null)
            {
                return HttpNotFound();
            }
            return View(HD);
        }

        // POST: HDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HD HD = db.HDs.Find(id);
            db.HDs.Remove(HD);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //public ActionResult Order(FormCollection form)
        //{
        //    try
        //    {
        //        List<NHANVIEN> nv = Session["nv"] as List<NHANVIEN>;
        //        NHANVIEN _nv = new NHANVIEN();
        //        List<HD> HD = Session["HD"] as List<HD>;
        //        HD _HD = new HD();
        //        _HD.ThoiGian = DateTime.Now;
        //        db.HDs.Add(_HD);
        //        foreach(var item in _nv.HoNhanVien)
        //        {
        //            HD _HD = new HD();
        //            _HD.MaHD = _HD.MaHD;
        //            _HD.ThoiGian = _HD.ThoiGian;
        //            _HD.MaNhanVien = _nv.MaNhanVien;
        //            _HD.MaHD = _HD.MaHD;


        //        }
        //        db.SaveChanges();

        //    }
        //}

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
