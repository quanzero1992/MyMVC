using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopWeb.Models;

namespace ShopWeb.Controllers
{
    public static class CommonDictionary
    {
        public static eshopperEntities db = new eshopperEntities();
        public static void LoadAllDictionary()
        {
            db.webconfigs.FirstOrDefault() ;
        }

    }
}