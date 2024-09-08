using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EcommerceWebApplicationMVC.Views.Product
{
    public class Product : PageModel
    {
        private readonly ILogger<Product> _logger;

        public Product(ILogger<Product> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}