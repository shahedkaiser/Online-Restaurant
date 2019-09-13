using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Utility;

namespace Spice.Areas.Admin.Controllers
{
    [Authorize(Roles =SD.ManagerUser)]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET
        public async Task<IActionResult> Index()
        {
            var categories = await _db.Category.ToListAsync();
            return View(categories);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Add(category);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(category);
            }
        }

        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            else
            {
                var category = await _db.Category.FindAsync(id);
                if(category==null)
                {
                    return NotFound();
                }
                else
                {
                    return View(category);
                }
            }
        }

        //POST- EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if(ModelState.IsValid)
            {
                _db.Category.Update(category);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(category);
            }
        }

        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var category = await _db.Category.FindAsync(id);
                if (category == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(category);
                }
            }
        }

        //POST - DELETE
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var category = await _db.Category.FindAsync(id);
            if(category==null)
            {
                return View();
            }
            else
            {
                _db.Category.Remove(category);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }

        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var category = await _db.Category.FindAsync(id);
                if (category == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(category);
                }
            }
        }

        //POST- DETAILS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(Category category)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Edit", "Category", new { id = category.Id}); 
            }
            else
            {
                return View(category);
            }
        }
    }
}