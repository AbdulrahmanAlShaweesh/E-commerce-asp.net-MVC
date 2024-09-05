using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApplicationMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EcommerceWebApplicationMVC.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        
        private readonly EcommerceDbContext _context; 

        public ProductController(EcommerceDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var Response = await _context.Products.ToListAsync();
            return View(Response);
        }

         
    }
}