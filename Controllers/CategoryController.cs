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
     
    public class CategoryController : Controller
    {
         

        private readonly EcommerceDbContext _context; 

        public CategoryController(EcommerceDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categorys.ToListAsync();
            return View(categories);
        }
      
    }
}