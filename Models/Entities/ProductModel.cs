using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApplicationMVC.Data;

namespace EcommerceWebApplicationMVC.Models.Entities
{
    public class ProductModel
    {
        [Key] 
        public int Id {get; set;} 

        public string Name {get; set;} = string.Empty; 

        public string Description {get; set;} = string.Empty;

        public double Price {get; set;} 

        public string ImageUrl {get; set;} = string.Empty; 

        public ProductColor? productColor { get; set; }   // we will store the color for each product
    }
}