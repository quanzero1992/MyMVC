//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Stars { get; set; }
        public string Brands { get; set; }
        public Nullable<int> Condition { get; set; }
        public string MainImage { get; set; }
        public Nullable<sbyte> Status { get; set; }
        public Nullable<int> ProductTypeID { get; set; }
    }
}
