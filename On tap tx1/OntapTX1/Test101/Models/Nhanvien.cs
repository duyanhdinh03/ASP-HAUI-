using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test101.Models
{
    public class Nhanvien
    {
        public string manv { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public decimal songaylam { get; set; }

        public decimal luongngay {  get; set; }
        public decimal tienluong
        {
            get { return songaylam * luongngay; }
        }

        public Nhanvien () { }
        public Nhanvien( string manv, string hoten, string diachi, decimal songaylam, decimal luongngay)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.songaylam = songaylam;
            this.luongngay = luongngay;
        }
    }
}