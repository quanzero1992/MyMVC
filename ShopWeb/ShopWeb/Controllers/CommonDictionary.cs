using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopWeb.Models;

namespace ShopWeb.Controllers
{
    public static class CommonDictionary
    {
        public static eshopperEntities db ;
        public static void LoadAllDictionary()
        {
            db = new eshopperEntities();
            db.webconfigs.FirstOrDefault() ;
            db.brands.AsEnumerable();
            db.categories.AsEnumerable();
            db.category_brand.AsEnumerable();
            db.sociallinks.AsEnumerable();
        }

    }

    public static class DataUtility
    {
        public static DateTime ConvertToDateTime(this object obj)
        {
            if (obj == null || obj == DBNull.Value || string.IsNullOrEmpty(obj.ToString())) return DateTime.MinValue;
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }
        public static Int32 ConvertToInt(this object obj, int defaultValue = 0)
        {
            if (obj == DBNull.Value) return defaultValue;
            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            { return defaultValue; }
        }

        public static decimal ConvertToDecimal(this object obj, int defaultValue = 0)
        {
            if (obj == DBNull.Value) return defaultValue;
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch
            { return defaultValue; }
        }

        public static double ConvertToDouble(this object obj, int defaultValue = 0)
        {
            if (obj == null || obj == DBNull.Value || string.IsNullOrEmpty(obj.ToString())) return defaultValue;
            try
            {
                return Convert.ToDouble(obj);
            }
            catch
            { return defaultValue; }
        }
    }
}