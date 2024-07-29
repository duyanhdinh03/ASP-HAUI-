using Dang1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dang1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Cau1()
        {
            return View();
        }
        public ActionResult Cau2()
        {
            return View();
        }
        public ActionResult KetQua(Hang s)
        {
            return View(s);
        }
    }
}