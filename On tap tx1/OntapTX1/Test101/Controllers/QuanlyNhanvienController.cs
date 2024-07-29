using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Test101.Models;

namespace Test101.Controllers
{
    public class QuanlyNhanvienController : Controller
    {
        public List<Nhanvien> danhsach;
        public QuanlyNhanvienController()
        {
            danhsach = new List<Nhanvien>()
            {
                new Nhanvien {
                    manv = "Nv01",
                    hoten = "Nguyễn Vân Anh",
                    diachi = "Hà Nội",
                    songaylam = 15,
                    luongngay = 200000
                },
                new Nhanvien
                {
                    manv = "Nv02",
                    hoten = "Lê Thu Hà",
                    diachi = "Hải Phòng",
                    songaylam = 27,
                    luongngay = 250000
                },
                new Nhanvien
                {
                    manv = "Nv03",
                    hoten = "Nguyễn Văn Hoàng",
                    diachi = "Hà Nội",
                    songaylam = 18,
                    luongngay = 250000
                },
                new Nhanvien
                {
                    manv = "Nv04",
                    hoten = "Trần Thu Hương",
                    diachi = "Hải Phòng",
                    songaylam = 25,
                    luongngay = 190000
                },
                new Nhanvien
                {
                    manv = "Nv05",
                    hoten = "Ngô Phương Thảo",
                    diachi = "Quảng Ninh",
                    songaylam = 20,
                    luongngay = 180000
                }
            };
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DSNV()
        {
            ViewBag.listnv1 = danhsach.Where(nv => nv.songaylam < 20).ToList();
            ViewBag.listnv2 = danhsach.Where(nv => nv.luongngay > 190000).ToList();
            return View();
        }

        public ActionResult NhapNV()
        {
            return View();
        }

        public ActionResult HienthiThongtin(Nhanvien nv)
        {
            string path = Server.MapPath("~/TTNV.txt");
            string[] ttnv = { nv.manv, nv.hoten, nv.diachi, nv.songaylam.ToString(), nv.luongngay.ToString(), nv.tienluong.ToString() };
            System.IO.File.WriteAllLines(path, ttnv);
            return View(nv);
        }


    }
}