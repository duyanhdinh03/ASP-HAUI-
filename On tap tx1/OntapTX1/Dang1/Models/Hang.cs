using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dang1.Models
{
    public class Hang
    {
        public string mahang { get; set; }
        public string tenhang { get; set; }
        public string loaihang { get; set; }
        public double dongia { get; set; }
        public int soluong { get; set; }
        public double thanhtien
        {
            get
            {
                if (soluong >= 100) return soluong * dongia * 0.9;
                else return soluong * dongia;
            }
        }
    }
}