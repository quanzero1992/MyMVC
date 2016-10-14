using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopWeb.Models;

namespace ShopWeb.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        eshopperEntities db = new eshopperEntities();
        //
        // GET: /Admin/Products/

        public ActionResult Index()
        {
            return View(db.products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(product pd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.products.Add(pd);
                    int res = db.SaveChanges();
                    if (res > 0)
                        return RedirectToAction("Index");
                    else
                        ModelState.AddModelError("", "Thêm mới không thành công");

                }
                return View(pd);
            }
            catch
            {
                ModelState.AddModelError("", "Thêm mới không thành công");
                return View();
            }
        }
    }
}
