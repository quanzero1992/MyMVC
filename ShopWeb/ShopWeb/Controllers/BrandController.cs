using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopWeb.Models;

namespace ShopWeb.Controllers
{
    public class BrandController : Controller
    {
        //
        // GET: /Brand/

        public ActionResult Index()
        {
            return View();
        }

        eshopperEntities db = new eshopperEntities();


    }
}
