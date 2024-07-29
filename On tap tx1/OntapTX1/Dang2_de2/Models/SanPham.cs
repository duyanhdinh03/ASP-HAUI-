using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dang2_de2.Models
{
    public class SanPham
    {
        public string masp { get; set; }

        public string tensanpham { get; set; }

        public int soluong { get; set; }

        public double giatien { get; set; }

        public int giamgia { get; set; }

        public double thanhtien
        {
            get
            {
                if (giamgia == 0)
                {
                    return giatien * soluong;
                }
                else
                {
                    return giatien * soluong * 0.9;
                }
            }
        }
    }
}