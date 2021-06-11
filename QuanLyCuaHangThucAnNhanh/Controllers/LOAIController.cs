using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using QuanLyCuaHangThucAnNhanh.Models;
using System.Web.Security;

namespace QuanLyCuaHangThucAnNhanh.Controllers
{
    public class LOAIController : Controller
    {
        // GET: LOAI
        QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities();

        public ActionResult Index(int maloaimonan = 0)
        {
            if (maloaimonan == 0)
            {
                var mONANs = db.MONANs;
                return View(mONANs.ToList());
            }
            else
            {
                var mONANs = db.MONANs.Where(x => x.MaLoaiMonAn == maloaimonan);
                return View(mONANs.ToList());
            }
        }

    }
}