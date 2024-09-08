using System;
using System.Collections.Generic;
using System.Linq;
using EcommerceWebApplicationMVC.Models.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceWebApplicationMVC.Data
{
    public class ApplicationInitalizer
    {
        // This function helps us to add default data to the database if the database does not have data inside it.
        public static void Seed(IServiceProvider builder)
        {
            using (var applicationservices = builder.CreateScope())
            {
                var context = applicationservices.ServiceProvider.GetRequiredService<EcommerceDbContext>();

                context.Database.EnsureCreated();

                // Ensure that categories are seeded first
                if (!context.Categorys.Any())
                {
                    var categories = new List<CategoryModel>
                    {
                        new CategoryModel { Name = "C1", Description = "This is the first category" },
                        new CategoryModel { Name = "C2", Description = "This is the second category" },
                        new CategoryModel { Name = "C3", Description = "This is the third category" }
                    };

                    context.Categorys.AddRange(categories); // Adds categories to the database
                    context.SaveChanges();
                }

                // Retrieve the seeded categories
                var existingCategories = context.Categorys.ToList();

                // Ensure that products are seeded with a valid CategoryId
                if (!context.Products.Any())
                {
                    var products = new List<ProductModel>
                    {
                        new ProductModel
                        {
                            Name = "Product 1",
                            Description = "This is a product 1",
                            Price = 44,
                            ImageURL = "https...",
                            productColor = ProductColor.Red,
                            CategoryId = existingCategories[0].Id // Set a valid CategoryId
                        },
                        new ProductModel
                        {
                            Name = "Product 2",
                            Description = "This is a product 2",
                            Price = 45.3,
                            ImageURL = "https...",
                            productColor = ProductColor.Green,
                            CategoryId = existingCategories[1].Id // Set a valid CategoryId
                        },
                        new ProductModel
                        {
                            Name = "Product 3",
                            Description = "This is a product 3",
                            Price = 2344,
                            ImageURL = "https...",
                            productColor = ProductColor.Yellow,
                            CategoryId = existingCategories[2].Id // Set a valid CategoryId
                        }
                    };

                    context.Products.AddRange(products); // Adds products to the database
                    context.SaveChanges();
                }
            }
        }
    }
}
