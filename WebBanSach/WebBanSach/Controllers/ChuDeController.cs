using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models;

namespace WebBanSach.Controllers
{
    public class ChuDeController : Controller
    {
        //
        // GET: /ChuDe/

        public ActionResult Index()
        {
            return View();
        }

        webbansachEntities db = new webbansachEntities();
        public PartialViewResult ChuDePartial()
        {
            var lstChuDe = db.chudes.Take(5).ToList();
            return PartialView(lstChuDe);
        }
    }
}
