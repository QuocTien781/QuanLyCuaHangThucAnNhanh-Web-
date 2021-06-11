using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyCuaHangThucAnNhanh.Models;

namespace QuanLyCuaHangThucAnNhanh.Controllers
{
    [Authorize(Roles = "true")]
    public class THONGKEController : Controller
    {
        private QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities();
        // GET: THONGKE
        public ActionResult Index()
        {

            var products = from c in db.CTHDs
                           join h in db.HDs on c.MaHD equals h.MaHD
                           join m in db.MONANs on c.MaMonAn equals m.MaMonAn
                           join ca in db.LOAIMONANs on m.MaLoaiMonAn equals ca.MaLoaiMonAn
                           select new Thongke()
                           {
                               maNV = h.MaNhanVien,
                               maMA = m.MaMonAn,
                               tenMA = m.TenMonAn,
                               soLuong = c.SoLuong,
                               donGia = m.GiaTien,
                               ngayGio = h.ThoiGian,
                               loai = ca.TenLoaiMonAN,
                               thanhTien = m.GiaTien * c.SoLuong,
                           };
            return View(products.ToList());
        }
    }
}