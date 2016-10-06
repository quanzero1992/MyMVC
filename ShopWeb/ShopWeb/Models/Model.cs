namespace ShopWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=eshopper")
        {
        }

        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<menu> menus { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<productdetail> productdetails { get; set; }
        public virtual DbSet<productimage> productimages { get; set; }
        public virtual DbSet<review> reviews { get; set; }
        public virtual DbSet<sociallink> sociallinks { get; set; }
        public virtual DbSet<webconfig> webconfigs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<brand>()
                .Property(e => e.BrandName)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<menu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<menu>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.Brands)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.MainImage)
                .IsUnicode(false);

            modelBuilder.Entity<productimage>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<sociallink>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<sociallink>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<sociallink>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<sociallink>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<webconfig>()
                .Property(e => e.ImageServer)
                .IsUnicode(false);

            modelBuilder.Entity<webconfig>()
                .Property(e => e.FavIcon)
                .IsUnicode(false);

            modelBuilder.Entity<webconfig>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<webconfig>()
                .Property(e => e.WebName)
                .IsUnicode(false);
        }
    }
}
