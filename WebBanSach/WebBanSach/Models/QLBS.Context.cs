﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanSach.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class webbansachEntities : DbContext
    {
        public webbansachEntities()
            : base("name=webbansachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chitietdonhang> chitietdonhangs { get; set; }
        public virtual DbSet<chude> chudes { get; set; }
        public virtual DbSet<donhang> donhangs { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<nhaxuatban> nhaxuatbans { get; set; }
        public virtual DbSet<sach> saches { get; set; }
        public virtual DbSet<tacgia> tacgias { get; set; }
        public virtual DbSet<thamgia> thamgias { get; set; }
    }
}
