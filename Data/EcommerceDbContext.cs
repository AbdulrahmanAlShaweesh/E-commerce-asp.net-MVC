using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApplicationMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWebApplicationMVC.Data
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {
            
        }

        public DbSet<ProductModel> Products {get; set;}
        public DbSet<CategoryModel> Categorys {get; set;}
    }
}