using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWeb.Areas.Admin.Controllers
{
    public class ImageController : Controller
    {
        //
        // GET: /Admin/Image/

        public ActionResult Index()
        {
            return View();
        }

        public bool FileUpload(string Path)
        {
            bool rs = false;
            if (!string.IsNullOrEmpty(Path))
            {
                string pic = System.IO.Path.GetFileName(Path);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/images/xxx"), pic);
                //// file is uploaded
                //File.SaveAs(path);

                //// save the image path path to the database or you can send image
                //// directly to database
                //// in-case if you want to store byte[] ie. for DB
                //using (MemoryStream ms = new MemoryStream())
                //{
                //    File.InputStream.CopyTo(ms);
                //    byte[] array = ms.GetBuffer();
                //}
                rs = true;
            }

            return rs;
        }

        public ActionResult FileUpload(HttpPostedFileBase File)
        {
            if (File != null)
            {
                string pic = System.IO.Path.GetFileName(File.FileName);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/images/profile"), pic);
                // file is uploaded
                File.SaveAs(path);

                // save the image path path to the database or you can send image
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                using (MemoryStream ms = new MemoryStream())
                {
                    File.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }

            }
            // after successfully uploading redirect the user
            return RedirectToAction("actionname", "controller name");
        }
    }
}
