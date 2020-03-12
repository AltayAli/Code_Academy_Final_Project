using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mozambik.Data.Entities;
using MozambikMVC.Data.DeletedEtities;
using MozambikMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mozambik.Data
{
    public class ProductDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public ProductDbContext(DbContextOptions options) : base(options) { }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<DeliveryInformation> DeliveryInformations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<DeletedMarka> DeletedMarkas { get; set; }
        public DbSet<DeletedModel> DeletedModels { get; set; }
        public DbSet<DeletedSubMenu> DeletedSubMenus { get; set; }
        public DbSet<DeletedCategory> DeletedCategories { get; set; }
        public DbSet<DeletedProduct> DeletedProducts { get; set; }
        public DbSet<DeletedMenu> DeletedMenus { get; set; }
        public DbSet<Category> Category { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<DeliveryInformation>().HasOne(x => x.Order).WithOne(x => x.DeliveryInformation).HasForeignKey<Order>(x=>x.DeliveryInformationID);


         
        }


    }
}
