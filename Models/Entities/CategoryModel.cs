using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApplicationMVC.Data;

namespace EcommerceWebApplicationMVC.Models.Entities
{
    public class CategoryModel
    {
        
        public CategoryModel()
        {
            Products = new HashSet<ProductModel>();
        }

        [Key] 
        public int Id {get; set;} 

        public string Name {get; set;} = string.Empty; 

        public string Description {get; set;} = string.Empty;

        public ICollection<ProductModel>? Products {get; set;}
    }
}