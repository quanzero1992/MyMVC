using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWeb.Areas.Admin.Controllers
{
    public static class CommonDictionary 
    {
        public static bool UploadImg(string Path)
        {
            bool rs = false;
            try
            {
                // code something
                if (!string.IsNullOrEmpty(Path))
                {
                    string pic = System.IO.Path.GetFileName(Path);
                  
                    rs = true;
                }
                else
                {
                    rs = false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return rs;
        }

    }
}
