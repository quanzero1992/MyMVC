using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopWeb.Models;

namespace ShopWeb.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/
        eshopperEntities db = new eshopperEntities();
        public ActionResult Index()
        {
            List<product> xx = db.products.ToList<product>();
            ViewBag.ImageServer = CommonDictionary.db.webconfigs.FirstOrDefault().ImageServer;
            Console.WriteLine(CommonDictionary.db.webconfigs.FirstOrDefault().ImageServer);
            return View(xx);
        }

    }
}
