using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardwareStoreV2.Domain.Models.Products;
using HardwareStoreV2.Domain.Models.Orders;
using HardwareStoreV2.Domain.Models.Entities;
using HardwareStoreV2.Domain.Models.Discounts;
using HardwareStoreV2.Domain.Models.Builds;
using HardwareStoreV2.Domain.Models.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace HardwareStoreV2.Infrastructure.Persistence.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<DetailType> DetailTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Build> Builds { get; set; }
        public DbSet<BuildItem> BuildItems { get; set; }
        public DbSet<DiscountCode> DiscountCodes { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }


        
        
        public string DbPath { get; }

        public ApplicationDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
