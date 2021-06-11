using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace QuanLyCuaHangThucAnNhanh.Models
{
    public class ViewModel
    {
        public CTHD CTHD { get; set; }
        public HD HD { get; set; }
        public LOAIMONAN LMA { get; set; }
        public NHANVIEN NV { get; set; }
        public MONAN MA { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.##0}")]
        public double ThanhTien { get; set; }
    }
}