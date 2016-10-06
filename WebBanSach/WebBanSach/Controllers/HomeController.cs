﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models;

namespace WebBanSach.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        webbansachEntities db = new webbansachEntities();

        public ActionResult Index()
        {
            return View(db.saches.Take(10).Where(x=>x.Moi ==1).ToList<sach>());
        }
      
    }
}
