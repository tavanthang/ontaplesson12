using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TvtK22CNTLesson11_2210900063.Controllers
{
    public class TvtHomeController : Controller
    {
        public ActionResult TvtIndex()
        {
            return View();
        }

        public ActionResult TvtAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TvtContact()
        {
            ViewBag.msv = "2210900063";
            ViewBag.fullname = "tạ văn thắng ";


            return View();
        }
    }
}