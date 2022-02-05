using KlassyCafe.Bl;
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
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class HrController : Controller
    {
        IEmployeeServic employeeServic;
        IJopsService jopService;
        public HrController(IEmployeeServic employee , IJopsService jop)
        {
            employeeServic = employee;
            jopService = jop;
        }
        public IActionResult List()
        {
            return View(employeeServic.GetAll());
        }

        public IActionResult Edit(int? id)
        {
            ViewBag.Jop = jopService.GetAll();
            if (id != null)
            {
                TbEmployee emp = employeeServic.GetById(Convert.ToInt32(id));

                return View(emp);
            }
            else
            { return View(); }
        }

        public IActionResult Delete(int empId)
        {
            employeeServic.Delete(empId);
            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult> Save(TbEmployee emp , List<IFormFile> formFiles)
        {
            foreach (var file in formFiles)
            {
                if(file.Length>0)
                {
                    string ImageName = Guid.NewGuid().ToString() + ".jpg";
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads", ImageName);
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await file.CopyToAsync(stream);
                    }
                    emp.ImageName = ImageName;
                    int JopId = Convert.ToInt32(emp.JopId);
                    emp.Jop = jopService.GetById(JopId);

                }
            }
            int id = Convert.ToInt32(emp.NationalId);
            TbEmployee em = employeeServic.GetById(id);
            if (em == null)
            {
                
                employeeServic.Add(emp);
                            //he can add cheffs only ... i was looking for several roles but business logic don't require more than cheffs

            }
            else
            { 
                employeeServic.Edit(emp); 
            }

            return RedirectToAction("List");
        }
    }
}
