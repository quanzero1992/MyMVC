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

        public ActionResult SachTheoChuDe(int MaChuDe=0)
        {
            List<sach> lstsach = new List<sach>();
            lstsach = db.saches.Where(x => x.MaChuDe == MaChuDe).ToList();
            if (lstsach ==null)
            {
                Response.Status = "404";
                ViewBag.sach = "Không có sách nào thuộc chủ đề này";
                return null;
            }
            else
            ViewBag.ChuDe = db.chudes.FirstOrDefault(x => x.MaChuDe == MaChuDe).TenChuDe;
            return View(lstsach);
        }
    }
}
