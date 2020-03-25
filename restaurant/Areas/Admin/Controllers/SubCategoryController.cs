using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restaurant.Data;

namespace restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SubCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        // get-index
        public async Task<IActionResult> Index()
        {
            var subCategories = await _db.SubCategory.Include(s=>s.Category).ToListAsync();
            return View(subCategories);
        }
    }
}