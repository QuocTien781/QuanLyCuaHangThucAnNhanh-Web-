using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyCuaHangThucAnNhanh.Models;
namespace QuanLyCuaHangThucAnNhanh.Controllers
{
    [Authorize(Roles = "true, dif")]
    public class OrderController : Controller
    {
        private QuanLyCuaHangThucAnNhanh3Entities db = new QuanLyCuaHangThucAnNhanh3Entities();
        // GET: Order
        public List<Order> getOder()
        {
            List<Order> listOder = Session["order"] as List<Order>;
            if (listOder == null)
            {
                listOder = new List<Order>();
                Session["order"] = listOder;
            }
            return listOder;
        }

        public ActionResult Index()
        {
            List<Order> order = Session["order"] as List<Order>;
            return View(order);
        }
        [HttpPost]
        public ActionResult Index(string confirm_value)
        {
            if (confirm_value == "Xác nhận")
            {
                ViewBag.Message = "You clicked YES!";
            }
            else
            {
                ViewBag.Message = "You clicked NO!";
            }

            return View();
        }
    
    //Khai báo phương thức tạo order
    public RedirectToRouteResult CreateOrder(string MaMonAn)
        {
            if (Session["order"] == null)
            {
                Session["order"] = new List<Order>();
            }
            List<Order> order = Session["order"] as List<Order>;

            //Kiem tra san pham da chon co trong danh danh sach order chua
            if (order.FirstOrDefault(m => m.MaMonAn == MaMonAn) == null) //chua co trong danh sach order
            {
                MONAN ma = db.MONANs.Find(MaMonAn);
                Order newItem = new Order();
                newItem.MaMonAn = MaMonAn;
                newItem.TenMonAn = ma.TenMonAn;
                newItem.SoLuong = 1;
                newItem.DonGia = Convert.ToDouble(ma.GiaTien);
                order.Add(newItem);


            }
            else // san pham da co trong danh sach order ==> tang so luong len 1
            {
                Order taoorder = order.FirstOrDefault(m => m.MaMonAn == MaMonAn);
                taoorder.SoLuong++;

            }
            Session["order"] = order;
            return RedirectToAction("Index");

        }
        public RedirectToRouteResult Update(string MaMonAn, int txtSoLuong)
        {
            //Cập nhật số lượng
            List<Order> order = Session["order"] as List<Order>;
            Order item = order.FirstOrDefault(m => m.MaMonAn == MaMonAn);
            if (item != null)
            {

                if (txtSoLuong <=5 )
                {
                    item.SoLuong = txtSoLuong;
                }
                else
                {
                    item.SoLuong = 1;
                }

            }
         


            return RedirectToAction("Index");
        }
        public RedirectToRouteResult DelOrder(string MaMonAn)
        {
            // tìm order muốn xóa
            List<Order> order = Session["order"] as List<Order>;
            Order item = order.FirstOrDefault(m => m.MaMonAn == MaMonAn);
            if (item != null)
            {
                order.Remove(item);
                Session["order"] = order;
            }
            return RedirectToAction("Index");
        }
        ////Test thanh toán
        public ActionResult Oder()
        {
            if (Session["order"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            HD hd = new HD();
            hd.ThoiGian = DateTime.Now;
            if(User.Identity.Name != "")
            {
                string tendangnhap = Convert.ToString(Session["Account"]);
                hd.MaNhanVien = db.TAIKHOANs.Where(s => s.TenTaiKhoan == User.Identity.Name).FirstOrDefault().MaNhanVien;
            }
            else
            {

            }
            Response.Write("<script> alert('thanh toán thành công');</script>");
            db.HDs.Add(hd);
            db.SaveChanges();
            // add oder detail
            List<Order> listGH = getOder();
            foreach (var item in listGH)
            {
                CTHD cthd = new CTHD();
                cthd.MaHD = hd.MaHD;
                cthd.MaMonAn = item.MaMonAn;
                cthd.SoLuong = item.SoLuong;

                db.CTHDs.Add(cthd);
                foreach (var p in db.MONANs.Where(s => s.MaMonAn == cthd.MaMonAn))
                {
                    var cnsl = p.SoLuong - item.SoLuong;
                    p.SoLuong = cnsl;
                }

            }
           
            db.SaveChanges();
            Session["order"] = null;
            return RedirectToAction("Index", "Home");

        }
    }


}