using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopWeb.Models;

namespace ShopWeb.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Admin/Category/
        eshopperEntities db = new eshopperEntities();
        public ActionResult Index()
        {
            return View(db.categories.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(category pd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.categories.Add(pd);
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.categories.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(category item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    category prd = db.categories.Find(item.id);
                    prd.Desc = item.Desc;
                    prd.Name = item.Name;
                    prd.Symbol = item.Symbol;
                    prd.Category_Brand = item.Category_Brand;
                    int res = db.SaveChanges();

                    if (res > 0)
                        return RedirectToAction("Index");
                    else
                        ModelState.AddModelError("", "Cập nhật không thành công");

                }
                return View(item);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    category item = db.categories.Find(id);
                    if (item != null)
                    {
                        db.categories.Remove(item);
                        int res = db.SaveChanges();
                        if (res > 0)
                            return RedirectToAction("Index");
                        else
                            ModelState.AddModelError("", "Xóa không thành công");
                    }
                    else
                        ModelState.AddModelError("", "Không tồn tại sản phẩm có mã là " + id);
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

    }
}
