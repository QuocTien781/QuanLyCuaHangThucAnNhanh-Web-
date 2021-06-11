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
    public class TAIKHOANsController : Controller
    {
        private QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities();

        // GET: TAIKHOANs
        public ActionResult Index()
        {
            var tAIKHOAN = db.TAIKHOANs.Include(t => t.NHANVIEN).Include(t => t.QUYEN);
            return View(tAIKHOAN.ToList());
        }

        // GET: TAIKHOANs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }

        // GET: TAIKHOANs/Create
        public ActionResult Create()
        {
            TAIKHOAN tk = new TAIKHOAN();
            var tksau = db.TAIKHOANs.OrderByDescending(c => c.ID).FirstOrDefault();
            if (tksau == null)
            {
                tk.ID = "TK01";
            }
            else
            {
                tk.ID = "TK" + (Convert.ToInt32(tksau.ID.Substring(2, tksau.ID.Length - 2)) + 1).ToString();
            }
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "MaNhanVien");
            ViewBag.MaQuyen = new SelectList(db.QUYENs, "MaQuyen", "TenQuyen");
            return View(tk);
        }

        // POST: TAIKHOANs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TenTaiKhoan,MatKhau,MaQuyen,MaNhanVien")] TAIKHOAN tAIKHOAN)
        {
            if (ModelState.IsValid)
            {
                db.TAIKHOANs.Add(tAIKHOAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "MaNhanVien", tAIKHOAN.MaNhanVien);
            ViewBag.MaQuyen = new SelectList(db.QUYENs, "MaQuyen", "TenQuyen", tAIKHOAN.MaQuyen);
            return View(tAIKHOAN);
        }

        // GET: TAIKHOANs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "MaNhanVien", tAIKHOAN.MaNhanVien);
            ViewBag.MaQuyen = new SelectList(db.QUYENs, "MaQuyen", "TenQuyen", tAIKHOAN.MaQuyen);
            return View(tAIKHOAN);
        }

        // POST: TAIKHOANs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TenTaiKhoan,MatKhau,MaQuyen,MaNhanVien")] TAIKHOAN tAIKHOAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tAIKHOAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "MaNhanVien", tAIKHOAN.MaNhanVien);
            ViewBag.MaQuyen = new SelectList(db.QUYENs, "MaQuyen", "TenQuyen", tAIKHOAN.MaQuyen);
            return View(tAIKHOAN);
        }

        // GET: TAIKHOANs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }

        // POST: TAIKHOANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            db.TAIKHOANs.Remove(tAIKHOAN);
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
