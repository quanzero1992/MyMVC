using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopWeb.Models;

namespace ShopWeb.Areas.Admin.Controllers
{
    public class BrandsController : Controller
    {
        //
        // GET: /Admin/Brands/
        eshopperEntities db = new eshopperEntities();

        public ActionResult Index()
        {
            return View(db.brands.ToList());
        }

    }
}
