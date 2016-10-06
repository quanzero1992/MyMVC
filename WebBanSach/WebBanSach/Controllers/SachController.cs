using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models;

namespace WebBanSach.Controllers
{
    public class SachController : Controller
    {
        //
        // GET: /Sach/

        public ActionResult Index()
        {
            return View();
        }

        webbansachEntities db = new webbansachEntities();
        public PartialViewResult SachMoiPartial()
        {
            var lstSachMoi = db.saches.Take(3).ToList();
            return PartialView(lstSachMoi);
        }

        public ViewResult XemChiTiet(int MaSach=0)
        {
            sach detal = db.saches.SingleOrDefault(x => x.MaSach == MaSach);
            if (detal == null)
            {
                Response.Status = "404";
                return null;
            }
            return View(detal);
        }

    }
}
