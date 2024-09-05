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
    public class CategoryController : Controller
    {
        // step 1: we need to get a referance "copy" from the db
        private readonly EcommerceDbContext _context; 
        // step 2 inject the db into the controller
        public CategoryController(EcommerceDbContext context)
        {
            _context = context;   // now we have a copy of the db, and we call it depandany injection...
        }


        public async Task<IActionResult> Index()
        {
            var Response = await _context.Categorys.ToListAsync(); 
            Console.WriteLine(Response);
            return View(Response);   // we pass the category table to the index view
        }

         
    }
}