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
   
    public class ProductController : Controller
    {
        
        private readonly EcommerceDbContext _context; 

        public ProductController(EcommerceDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Response = await _context.Products.Include(x => x.Category).OrderBy(x => x.Price).ToListAsync();
            return View(Response);
        }

         
    }
}