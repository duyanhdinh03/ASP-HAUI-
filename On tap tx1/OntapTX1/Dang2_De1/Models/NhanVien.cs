using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dang2_De1.Models
{
    public class NhanVien
    {
        public string manv { get; set; }

        public string hoten { get; set; }

        public string diachi { get; set; }

        public int songaylam { get; set; }

        public decimal luongngay { get; set; }

        public decimal tienluong
        {
            get { return luongngay * songaylam; }
        }
        public NhanVien() { }
        public NhanVien(string manv, string hoten, string diachi, int songaylam, decimal luongngay)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.songaylam = songaylam;
            this.luongngay = luongngay;
        }
    }
}