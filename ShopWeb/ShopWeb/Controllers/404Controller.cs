using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWeb.Controllers
{
    public class _404Controller : Controller
    {
        //
        // GET: /404/

        public ActionResult Index()
        {
            return View();
        }

    }
}
