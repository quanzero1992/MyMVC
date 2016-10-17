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
                    //if (string.IsNullOrEmpty(pd.MainImage))
                    //{
                    //    if (CommonDictionary.UploadImg(pd.MainImage))
                    //    {

                            db.products.Add(pd);
                            int res = db.SaveChanges();                         
                            if (res > 0)
                                return RedirectToAction("Index");
                            else
                                ModelState.AddModelError("", "Thêm mới không thành công");
                    //    }
                    //    else
                    //        ModelState.AddModelError("", "Không thể upload hình ảnh, vui lòng thử lại");
                    //}
                    //else
                    //    ModelState.AddModelError("", "Dữ liệu hình ảnh không hợp lệ, vui lòng thử lại");
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
            return View(db.products.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(product item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    product prd = db.products.Find(item.ID);
                    prd.Name = item.Name;
                    prd.Price = item.Price;
                    prd.ProductTypeID = item.ProductTypeID;
                    prd.Stars = item.Stars;
                    prd.Status = item.Status;
                    prd.MainImage = item.MainImage;
                    prd.Brands = item.Brands;
                    prd.Condition = item.Condition;
                    prd.DateImport = item.DateImport;
                   
                    //db.Entry(db.products).State = System.Data.Entity.EntityState.Modified;

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
                    product item = db.products.Find(id);
                    if (item !=null)
                    {
                        db.products.Remove(item);
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
