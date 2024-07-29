using Dang2_De1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dang2_De1.Controllers
{
    public class QuanLyNhanVienController : Controller
    {
        public List<NhanVien> danhsach;
        
        public QuanLyNhanVienController() {
            danhsach = new List<NhanVien>
            {
                new NhanVien {
                    manv = "Nv01",
                    hoten = "Nguyễn Vân Anh",
                    diachi = "Hà Nội",
                    songaylam = 15,
                    luongngay = 200000
                },
                new NhanVien {
                    manv = "Nv02",
                    hoten = "Lê Thu Hà",
                    diachi = "Hải Phòng",
                    songaylam = 27,
                    luongngay = 250000
                },
                new NhanVien {
                    manv = "Nv03",
                    hoten = "Nguyễn Văn Hoàng",
                    diachi = "Hà Nội",
                    songaylam = 18,
                    luongngay = 250000
                },
                new NhanVien {
                    manv = "Nv04",
                    hoten = "Trần Thu Hương",
                    diachi = "Hải Phòng",
                    songaylam = 25,
                    luongngay = 190000
                },
                new NhanVien {
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

        public ActionResult DSNhanVien()
        {
            ViewBag.listnvNgay = danhsach.Where(n => n.songaylam > 20).ToList();
            ViewBag.listnvLuong = danhsach.Where(nv => nv.luongngay > 190000).ToList();
            return View();
        }

        public ActionResult NhapNV()
        {
            return View();
        }

        public ActionResult HienthiNV(NhanVien nv)
        {
            string path = Server.MapPath("~/TTNV.txt");
            string[] ttnv = { nv.manv, nv.hoten, nv.diachi, nv.songaylam.ToString(), nv.luongngay.ToString(), nv.tienluong.ToString() };
            System.IO.File.WriteAllLines(path, ttnv);
            return View(nv);
        }
    }
}