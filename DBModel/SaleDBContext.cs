using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.DBModel
{
    public class SaleDBContext : DbContext
    {
        public SaleDBContext(DbContextOptions<SaleDBContext> options) : base(options)
        {
            
        }
        public DbSet<ProductMaster> ProductMasters { get; set; }
        public DbSet<ImageMaster> ImageMasters { get; set; }
        public DbSet<SaleMaster> SaleMasters { get; set; }
        public DbSet<ProductSaleJoin> ProductSaleJoins { get; set; }
    }
    public static class DbInitializer{
        public static void Initialize(SaleDBContext context)
        {
            context.Database.EnsureCreated();
        }

     }

    
}
