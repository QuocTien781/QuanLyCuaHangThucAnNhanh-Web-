using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangThucAnNhanh.Models
{
    using System;
    public class Thongke
    {
        public string maNV { get; set; }
        public string maMA  { get; set; }
        public string tenMA { get; set; }
        public DateTime? ngayGio { get; set; }
        public int? soLuong { get; set; }
        public double? donGia { get; set; }
        public string loai { get; set; }
        public double? thanhTien { get; set; }
        public double? tongDoanhThu { get; set; }
    }
}