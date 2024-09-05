using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApplicationMVC.Data;

namespace EcommerceWebApplicationMVC.Dtos.Product
{
    public class ProductDto
    {
        public string Name {get; set;}   = string.Empty;

        public string Description {get; set;} = string.Empty;

        public double Price {get; set;} 

        public string ImageURL {get; set;} = string.Empty; 

        public ProductColor productColor {get; set;}
    }
}