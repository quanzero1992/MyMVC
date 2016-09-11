using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models;

namespace WebBanSach.Controllers
{
    public class NhaXuatBanController : Controller
    {
        //
        // GET: /NhaXuatBan/


        public ActionResult Index()
        {
            return View();
        }

        webbansachEntities db = new webbansachEntities();
        public PartialViewResult NhaXuatBanPartial()
        {
            var lstNXB = db.nhaxuatbans.Take(3).ToList();
            return PartialView(lstNXB);
        }

    }
}
