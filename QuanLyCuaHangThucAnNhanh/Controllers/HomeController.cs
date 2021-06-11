using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using QuanLyCuaHangThucAnNhanh.Models;
using System.Web.Security;
using PagedList;
using PagedList.Mvc;

namespace QuanLyCuaHangThucAnNhanh.Controllers
{
    public class HomeController : Controller
    {
        QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities();

        [Authorize]
        public ActionResult Index(int? page, string loaimonan, int maloaimonan = 0)
        {
            int pageSize = 8;
            int pageNum = (page ?? 1);

            if (loaimonan == null)
            {
                {
                    var danhsachmonan = db.MONANs.OrderByDescending(x => x.TenMonAn);
                    return View(danhsachmonan.ToPagedList(pageNum, pageSize));
                }
            }
            else
            {
                var danhsachmonan = db.MONANs.OrderByDescending(x => x.TenMonAn).Where(p => p.MaLoaiMonAn.ToString() == loaimonan);
                return View(danhsachmonan);
            }
        }
            public ActionResult Login()
        {
            return View();
        }

        //[Authorize(Roles = "true")]
        public ActionResult Order()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(TAIKHOAN model, string returnUrl)
        {
           
            var dataItem = db.TAIKHOANs.Where(x => x.TenTaiKhoan == model.TenTaiKhoan && x.MatKhau == model.MatKhau).FirstOrDefault();
            if (dataItem != null)
            {
                FormsAuthentication.SetAuthCookie(dataItem.TenTaiKhoan, false);
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid user/pass");
                return View();
            }
        }

        [Authorize]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Home");
        }
    }
}