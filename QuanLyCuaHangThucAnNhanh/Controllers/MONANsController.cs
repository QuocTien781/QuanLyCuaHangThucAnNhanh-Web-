using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.IO;
using System.Web.Mvc;
using QuanLyCuaHangThucAnNhanh.Models;
namespace QuanLyCuaHangThucAnNhanh.Controllers
{
  
    public class MONANsController : Controller
    {
        private QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities();

        // GET: MONANs
        public ActionResult Index(string loaimonan, int? page, double min = double.MinValue, double max = double.MaxValue)
        {
            return View(db.MONANs.ToList());
        }
    
        

                // GET: MONANs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONAN mONAN = db.MONANs.Find(id);
            if (mONAN == null)
            {
                return HttpNotFound();
            }
            return View(mONAN);
        }
        [Authorize(Roles = "true")]
        // GET: MONANs/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiMonAn = new SelectList(db.LOAIMONANs, "MaLoaiMonAn", "TenLoaiMonAN");
            MONAN nv = new MONAN();
            //sort the employee and get the last insert employee.
            var masau = db.MONANs.OrderByDescending(c => c.MaMonAn).FirstOrDefault();
            if (masau == null)
            {
                nv.MaMonAn = "MA01";
            }
            else
            {
                //using string substring method to get the number of the last inserted employee's EmployeeID 
                nv.MaMonAn= "MA" + (Convert.ToInt32(masau.MaMonAn.Substring(2, masau.MaMonAn.Length - 2)) + 1).ToString();
            }

            return View(nv);
        }

        // POST: MONANs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaMonAn,TenMonAn,GiaTien,Anh,MaLoaiMonAn,SoLuong")] MONAN mONAN,HttpPostedFileBase Anh)
        {
            if (ModelState.IsValid)
            {
                if (Anh!=null && Anh.ContentLength>0)
                {
                    string filename = Path.GetFileName(Anh.FileName);
                    string path = Server.MapPath("/Images" + filename);
                    mONAN.Anh = @"Images/" + filename;
                    Anh.SaveAs(path);
                }
                db.MONANs.Add(mONAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLoaiMonAn = new SelectList(db.LOAIMONANs, "MaLoaiMonAn", "TenLoaiMonAN", mONAN.MaLoaiMonAn);
            return View(mONAN);
        }
        [Authorize(Roles = "true")]
        // GET: MONANs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONAN mONAN = db.MONANs.Find(id);
            if (mONAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiMonAn = new SelectList(db.LOAIMONANs, "MaLoaiMonAn", "TenLoaiMonAN", mONAN.MaLoaiMonAn);
            return View(mONAN);
        }

        // POST: MONANs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaMonAn,TenMonAn,GiaTien,Anh,MaLoaiMonAn,SoLuong")] MONAN mONAN, HttpPostedFileBase AnhUpLoad,string Anh) 
        {
            if (ModelState.IsValid)
            {
                if (AnhUpLoad != null && AnhUpLoad.ContentLength > 0)
                {
                    string filename = Path.GetFileName(AnhUpLoad.FileName);
                    string path = Server.MapPath("~/Images" + filename);
                    mONAN.Anh = @"Images/" + filename.ToString().Trim();
                    AnhUpLoad.SaveAs(path);
                }
                else
                {
                    mONAN.Anh = Anh;//ko chọn thì giữ hình cũ
                }
                db.Entry(mONAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoaiMonAn = new SelectList(db.LOAIMONANs, "MaLoaiMonAn", "TenLoaiMonAN", mONAN.MaLoaiMonAn);
            return View(mONAN);
        }
        [Authorize(Roles = "true")]
        // GET: MONANs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONAN mONAN = db.MONANs.Find(id);
            if (mONAN == null)
            {
                return HttpNotFound();
            }
            return View(mONAN);
        }

        // POST: MONANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MONAN mONAN = db.MONANs.Find(id);
            db.MONANs.Remove(mONAN);
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
