using Dang2_de2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dang2_de2.Controllers
{
    public class QuanLySanPhamController : Controller
    {
        public List<SanPham> danhsach;

        public QuanLySanPhamController()
        {
            danhsach = new List<SanPham>
            {
                new SanPham
                {
                    masp = "S01",
                    tensanpham = "Sản phẩm 1",
                    soluong = 10,
                    giatien = 100,
                    giamgia = 0,
                },
                new SanPham
                {
                    masp = "S02",
                    tensanpham = "Sản phẩm 2",
                    soluong = 20,
                    giatien = 120,
                    giamgia = 1,
                },
                new SanPham
                {
                    masp = "S03",
                    tensanpham = "Sản phẩm 3",
                    soluong = 15,
                    giatien = 200,
                    giamgia = 1,
                },
                new SanPham
                {
                    masp = "S04",
                    tensanpham = "Sản phẩm 4",
                    soluong = 30,
                    giatien = 150,
                    giamgia = 0,
                },
                new SanPham
                {
                    masp = "S05",
                    tensanpham = "Sản phẩm 5",
                    soluong = 20,
                    giatien = 50,
                    giamgia = 1,
                }
            };
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hienthi()
        {
            ViewBag.ds1 = danhsach.Where(ds => ds.giatien > 100).ToList();
            ViewData["ds2"] = danhsach.Where(ds => ds.giamgia == 1).ToList();
            return View();
        }

        public ActionResult NhapSP()
        {
            return View();
        }
        public ActionResult HienThiThongTin(SanPham sp)
        {
            string path = Server.MapPath("~/Thongtin.txt");
            string[] thongtin = { sp.masp, sp.tensanpham, sp.soluong.ToString(), sp.giatien.ToString(), sp.giatien.ToString(), sp.thanhtien.ToString() };
            System.IO.File.WriteAllLines(path, thongtin);
            return View(sp);
        }

    }
}