using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApplicationMVC.Data;

namespace EcommerceWebApplicationMVC.Models.Entities
{
    public class ProductModel
    {
        [Key] 
        public int Id {get; set;} 

        public string Name {get; set;}   = string.Empty;

        public string Description {get; set;} = string.Empty;

        public double Price {get; set;} 

        public string ImageURL {get; set;} = string.Empty; 

        public ProductColor productColor {get; set;}

        public int CategoryId {get; set;}
        [ForeignKey(nameof(CategoryId))]
        public CategoryModel? Category {get; set;}
    }
}

