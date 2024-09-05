using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApplicationMVC.Models.Entities;

namespace EcommerceWebApplicationMVC.Dtos
{
    public class CategoryDto
    {
        public string Name {get; set;} = string.Empty; 

        public string Description {get; set;} = string.Empty;

        public ICollection<ProductModel>? Products {get; set;}
    }
}

