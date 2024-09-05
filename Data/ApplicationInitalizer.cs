using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApplicationMVC.Models.Entities;

namespace EcommerceWebApplicationMVC.Data
{
    public class ApplicationInitalizer
    {   
        // this function helps us to add defulat data to db in db does not has a data inside it.
        public static void Seed(IServiceProvider builder) {
            using (var applicationservices = builder.CreateScope())
            {
                var context = applicationservices.ServiceProvider.GetRequiredService<EcommerceDbContext>();

                context.Database.EnsureCreated();
                // if the context does not include a data then will add this below object into it
                if (!context.Categorys.Any()){
                    var categories = new List<CategoryModel> {
                        new CategoryModel (){
                            Name = "C1", 
                            Description = "This is the first category"
                        },
                        new CategoryModel (){
                            Name = "C2", 
                            Description = "This is the second category"
                        },
                        new CategoryModel (){
                            Name = "C3", 
                            Description = "This is the third category"
                        }
                    };
                    context.Categorys.AddRange();   // to add the data into the database. 
                    context.SaveChanges();
                }
                // To add to the Product Table... 
                if(!context.Products.Any()){
                    var products = new List<ProductModel> {
                        new ProductModel() {
                            Name = "Product 1",
                            Description = "This is a product 1",
                            Price = 44, 
                            ImageURL = "https...", 
                            productColor = ProductColor.Red,

                        }, 
                        new ProductModel() {
                            Name = "Product 2",
                            Description = "This is a product 2",
                            Price = 45.3, 
                            ImageURL = "https...", 
                            productColor = ProductColor.Green,

                        }, 
                        new ProductModel() {
                            Name = "Product 3",
                            Description = "This is a product 3",
                            Price = 2344, 
                            ImageURL = "https...", 
                            productColor = ProductColor.Yellow,

                        }
                    };
                    context.Products.AddRange(); 
                    context.SaveChanges();
                }     

            }
        } 
    }
}