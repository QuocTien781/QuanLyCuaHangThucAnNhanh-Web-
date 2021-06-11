using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyCuaHangThucAnNhanh.Models;
using System.Collections;
namespace QuanLyCuaHangThucAnNhanh.Controllers
{
   
    public class MenuLoaiController : Controller
    {
        // GET: MenuLoai
        public ActionResult Index()
        {
            using (QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities())
            {
                var loaimonan = db.LOAIMONANs.ToList();
                Hashtable tenloai = new Hashtable();
                foreach(var item in loaimonan)
                {
                    tenloai.Add(item.MaLoaiMonAn, item.TenLoaiMonAN);
                }
                ViewBag.TenLoai = tenloai;
                return PartialView("Index");
            }
         
        }
    }
}