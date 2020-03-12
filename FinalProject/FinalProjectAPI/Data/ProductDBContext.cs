using FinalProjectAPI.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Data
{
    public class ProductDBContext :IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public ProductDBContext(DbContextOptions options) : base(options) { }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DeliveryInformation> DeliveryInformations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<PageBanner> PageBanners { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ModelColor> ModelColors { get; set; }
        public DbSet<ProductMarka> ProductMarkas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Order>()
                .HasOne(x => x.DeliveryInformation)
                .WithOne(x => x.Order)
                .HasForeignKey<DeliveryInformation>(x => x.OrderID);

            builder.Entity<ProductMarka>().HasKey(x => new { x.MarkaID, x.ProductID });
            builder.Entity<ProductMarka>().HasOne(x => x.Marka).WithMany(x => x.ProductMarkas);
            builder.Entity<ProductMarka>().HasOne(x => x.Product).WithMany(x => x.ProductMarkas);

            builder.Entity<ModelColor>().HasOne(x => x.Color).WithMany(x => x.ModelColors);
            builder.Entity<ModelColor>().HasOne(x => x.Model).WithMany(x => x.ModelColors);
            builder.Entity<ModelColor>().HasKey(x => new { x.ModelId, x.ColorID });

        }
    }
}
