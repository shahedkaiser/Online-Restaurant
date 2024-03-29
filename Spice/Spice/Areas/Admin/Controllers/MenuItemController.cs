﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models.ViewModels;
using Spice.Utility;

namespace Spice.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.ManagerUser)]
    [Area("Admin")]
    public class MenuItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;

        [BindProperty]
        public MenuItemViewModel MenuItemVm { get; set; }

        public MenuItemController(ApplicationDbContext db,IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            MenuItemVm = new MenuItemViewModel()
            {
                Category = _db.Category,
                MenuItem = new Models.MenuItem()
            };
        }
        
        public async Task<IActionResult> Index()
        {
            var menuItems =await _db.MenuItem.Include(m=>m.Category).Include(m=>m.SubCategory).ToListAsync();
            return View(menuItems);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View(MenuItemVm);
        }

        //POST - CREATE
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePost()
        {
            MenuItemVm.MenuItem.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());
            if(!ModelState.IsValid)
            {
                return View(MenuItemVm);
            }

            _db.MenuItem.Add(MenuItemVm.MenuItem);
            await _db.SaveChangesAsync();

            //Work on the image saving section

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var menuItemFromDb = await _db.MenuItem.FindAsync(MenuItemVm.MenuItem.Id);

            if(files.Count>0)
            {
                var uploads = Path.Combine(webRootPath, "images");
                var extension = Path.GetExtension(files[0].FileName);
                using(var filesStream=new FileStream(Path.Combine(uploads,MenuItemVm.MenuItem.Id+extension),FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                menuItemFromDb.Image = @"\images\" + MenuItemVm.MenuItem.Id + extension;
            }
            else
            {
                var uploads = Path.Combine(webRootPath, @"images\" + SD.DefaultFoodImage);
                System.IO.File.Copy(uploads, webRootPath + @"\images\" + MenuItemVm.MenuItem.Id + ".png");
                menuItemFromDb.Image = @"\images\" + MenuItemVm.MenuItem.Id + ".png";
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            MenuItemVm.MenuItem = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).SingleOrDefaultAsync(m => m.Id == id);
            MenuItemVm.SubCategory = await _db.SubCategory.Where(s => s.CategoryId == MenuItemVm.MenuItem.CategoryId).ToListAsync();

            if(MenuItemVm.MenuItem==null)
            {
                return NotFound();
            }

            return View(MenuItemVm);
        }

        //POST - EDIT
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            MenuItemVm.MenuItem.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());
            if (!ModelState.IsValid)
            {
                MenuItemVm.SubCategory = await _db.SubCategory.Where(s => s.CategoryId == MenuItemVm.MenuItem.CategoryId).ToListAsync();
                return View(MenuItemVm);
            }


            //Work on the image saving section

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var menuItemFromDb = await _db.MenuItem.FindAsync(MenuItemVm.MenuItem.Id);

            

            if (files.Count > 0)
            {

                var uploads = Path.Combine(webRootPath, "images");
                var extension = Path.GetExtension(files[0].FileName);

                //Delete old image
                var imagePath = Path.Combine(webRootPath, menuItemFromDb.Image.TrimStart('\\'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                using (var filesStream = new FileStream(Path.Combine(uploads, MenuItemVm.MenuItem.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                menuItemFromDb.Image = @"\images\" + MenuItemVm.MenuItem.Id + extension;
            }

            menuItemFromDb.Name = MenuItemVm.MenuItem.Name;
            menuItemFromDb.Description = MenuItemVm.MenuItem.Description;
            menuItemFromDb.Price = MenuItemVm.MenuItem.Price;
            menuItemFromDb.Spicyness = MenuItemVm.MenuItem.Spicyness;
            menuItemFromDb.CategoryId = MenuItemVm.MenuItem.CategoryId;
            menuItemFromDb.SubCategoryId = MenuItemVm.MenuItem.SubCategoryId;
            menuItemFromDb.Name = MenuItemVm.MenuItem.Name;

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MenuItemVm.MenuItem = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).SingleOrDefaultAsync(m => m.Id == id);
            MenuItemVm.SubCategory = await _db.SubCategory.Where(s => s.CategoryId == MenuItemVm.MenuItem.CategoryId).ToListAsync();

            if (MenuItemVm.MenuItem == null)
            {
                return NotFound();
            }

            return View(MenuItemVm);
        }

        //POST- DETAILS
        [HttpPost,ActionName("Details")]
        [ValidateAntiForgeryToken]
        public IActionResult DetailsPost(int? id)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Edit", "MenuItem", new { id = MenuItemVm.MenuItem.Id });
            }
            else
            {
                return View();
            }
        }

        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MenuItemVm.MenuItem = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).SingleOrDefaultAsync(m => m.Id == id);
            MenuItemVm.SubCategory = await _db.SubCategory.Where(s => s.CategoryId == MenuItemVm.MenuItem.CategoryId).ToListAsync();

            if (MenuItemVm.MenuItem == null)
            {
                return NotFound();
            }

            return View(MenuItemVm);
        }

        //POST - DELETE
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var menuItem = await _db.MenuItem.FindAsync(id);
            if (menuItem == null)
            {
                return View();
            }
            else
            {
                _db.MenuItem.Remove(menuItem);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    }
}