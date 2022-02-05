
using KlassyCafe.Models;
using KlassyCafe.NewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ItemsController : Controller
    {
        IitemService item;
        ICategoryService category;
        public ItemsController(IitemService  IitemService,ICategoryService categoryService)
        {
           item  = IitemService;
            category =categoryService ;
        }
        public IActionResult List()
        {

            return View(item.GetAll());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int itemId)
        {
            item.Delete(itemId);
            return RedirectToAction("List");
        }
        
        public IActionResult Edit(int? id)
        {
            ViewBag.Categories = category.GetAll();
            if(id != null)
            {
                return View(item.GetById(Convert.ToInt32(id)));
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Save(TbItem CameItem, List<IFormFile> formFiles)
        {
            foreach(var file in formFiles)
            {
                if(file.Length>0)
                {
                    string ImageName = Guid.NewGuid().ToString() + ".jpg";
                    var FilePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads", ImageName);
                    using(var stream=System.IO.File.Create(FilePath))
                    {
                        await file.CopyToAsync(stream);
                    }
                    CameItem.ImageName = ImageName;
                }
            }

            if(CameItem.ItemId == 0 || CameItem.ItemId == null)
            {
                int newId = item.GetAll().Count() + 1;
                CameItem.ItemId = newId;
                item.Add(CameItem);
            }
            else
            { item.Edit(CameItem); }

            return RedirectToAction("List");
        }
    }
}
