using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangThucAnNhanh.Models
{
    public class Order
    {
        public string MaOrder { get; set; }
        public string MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public Nullable<int> cnsl { get; set; }
        public double ThanhTien
        {
            get { return SoLuong * DonGia; }
        }

        internal object Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}